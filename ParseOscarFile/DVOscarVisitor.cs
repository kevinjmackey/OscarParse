using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using uast;

namespace DV.Oscar
{
    public static class StringExtensions
    {
        public static string Left(this string str, int length)
        {
            return str.Substring(0, Math.Min(length, str.Length));
        }

        public static string Right(this string str, int length)
        {
            return str.Substring(str.Length - Math.Min(length, str.Length));
        }
    }
    class DVOscarVisitor : DVOscarParserBaseVisitor<bool>
    {
        private const bool TRUE = true;
        private string _dvoFile;
        private uast.UastNode _uastTree;
        private uast.UastNode _currentParent;
        private Stack _parentStack;
        public string DvoFile { set => _dvoFile = value; }
        public UastNode UastTree { get => _uastTree; }

        public DVOscarVisitor() => _parentStack = new Stack();
        public DVOscarVisitor(string sqlFile)
        {
            _dvoFile = sqlFile;
            _parentStack = new Stack();
        }
        private string GetFunctionDef()
        {
            string result = "";

            return result;
        }
        private string GetDefaultValue(DVOscarParser.Default_valueContext _defaultValueCtx)
        {
            string result = "";

            return result;
        }
        public override bool VisitDvoscar_file(DVOscarParser.Dvoscar_fileContext context)
        {
            _uastTree = new uast.UastNode();
            _uastTree.InternalType = "dvo:File";
            _uastTree.Token = _dvoFile;
            _uastTree.AddRole(uast.Role.FILE);
            _currentParent = _uastTree;
            bool tf = VisitChildren(context);

            return TRUE;
        }
        public override bool VisitBlock(DVOscarParser.BlockContext context)
        {
            foreach (var child in context.children)
            {
                if (child.GetType() == typeof(Antlr4.Runtime.Tree.TerminalNodeImpl))
                {
                    UastNode keywordNode = new UastNode();
                    keywordNode.InternalType = $"dvo:{child.GetText().ToUpper()}";
                    keywordNode.Token = child.GetText().ToUpper();
                    keywordNode.AddRole(Role.PRIMITIVE);
                    if (child.GetText().ToUpper() == "BEGIN")
                    {
                        keywordNode.AddRole(Role.BLOCK);
                        keywordNode.Parent = _currentParent;
                        _currentParent.AddChild(keywordNode);
                        _parentStack.Push(_currentParent);
                        _currentParent = keywordNode;
                    }
                    else
                    {
                        keywordNode.AddRole(Role.END_BLOCK);
                        _currentParent = (UastNode)_parentStack.Pop();
                        keywordNode.Parent = _currentParent;
                        _currentParent.AddChild(keywordNode);
                    }
                }
                if (child.GetType() == typeof(DVOscarParser.Datastore_statementContext))
                {
                    bool tf = VisitDatastore_statement((DVOscarParser.Datastore_statementContext)child);
                }
            }
             return TRUE;
        }
        public override bool VisitDatastore_statement([NotNull] DVOscarParser.Datastore_statementContext context)
        {
            UastNode node = new UastNode();
            foreach (var child in context.children)
            {
                if (child.GetType() == typeof(DVOscarParser.IdentifierContext))
                {
                    node.InternalType = $"dvo:Datastore";
                    node.Token = child.GetText();
                    node.AddRole(Role.DATASOURCE);
                    node.AddRole(Role.IDENTIFIER);
                    _currentParent.AddChild(node);
                }
                if (child.GetType() == typeof(DVOscarParser.Display_nameContext))
                {
                    node.AddProperty("Display Name", child.GetText());
                    node.Parent = _currentParent;
                }
                if (child.GetType() == typeof(DVOscarParser.Parent_item_statementContext))
                {
                    _parentStack.Push(_currentParent);
                    _currentParent = node;
                    bool tf = VisitParent_item_statement((DVOscarParser.Parent_item_statementContext)child);
                    _currentParent = (UastNode)_parentStack.Pop();
                }
                if (child.GetType() == typeof(DVOscarParser.PropertiesContext))
                {
                    DVOscarParser.PropertiesContext properties = (DVOscarParser.PropertiesContext)child;
                    foreach (DVOscarParser.PropertyContext property in properties.children)
                    {
                        foreach (var propertyDef in property.children)
                        {
                            if (propertyDef.GetType() == typeof(DVOscarParser.PairContext))
                            {
                                node.AddProperty(propertyDef.GetChild(0).GetText().Replace("\"", ""), propertyDef.GetChild(2).GetText());
                            }
                        }
                    }
                }
            }
            return TRUE;
        }
        public override bool VisitItem_statement([NotNull] DVOscarParser.Item_statementContext context)
        {
            UastNode node = new UastNode();
            _parentStack.Push(_currentParent);
            _currentParent.AddChild(node);
            node.Parent = _currentParent;
            foreach (var child in context.children)
            {
                if (child.GetType() == typeof(DVOscarParser.IdentifierContext))
                {
                    node.InternalType = $"dvo:Item";
                    node.Token = child.GetText();
                    node.AddRole(Role.ENTITY);
                    node.AddRole(Role.IDENTIFIER);
                }
                if (child.GetType() == typeof(DVOscarParser.Display_nameContext))
                {
                    node.AddProperty("Display Name", child.GetText());
                }
                if (child.GetType() == typeof(DVOscarParser.PluralContext))
                {
                    DVOscarParser.PluralContext plural = (DVOscarParser.PluralContext)child;
                    node.AddProperty("Plural", plural.GetChild(1).GetText());
                }
                if (child.GetType() == typeof(DVOscarParser.AssociationsContext))
                {
                    _currentParent = node;
                    bool tf = VisitAssociations((DVOscarParser.AssociationsContext)child);
                }
                if (child.GetType() == typeof(DVOscarParser.Attribute_defContext))
                {
                    _currentParent = node;
                    bool tf = VisitAttribute_def((DVOscarParser.Attribute_defContext)child);
                }
                if (child.GetType() == typeof(DVOscarParser.Child_item_statementContext))
                {
                    bool tf = VisitChild_item_statement((DVOscarParser.Child_item_statementContext)child);
                }
                if (child.GetType() == typeof(DVOscarParser.PropertiesContext))
                {
                    DVOscarParser.PropertiesContext properties = (DVOscarParser.PropertiesContext)child;
                    foreach (DVOscarParser.PropertyContext property in properties.children)
                    {
                        foreach (var propertyDef in property.children)
                        {
                            if (propertyDef.GetType() == typeof(DVOscarParser.PairContext))
                            {
                                node.AddProperty(propertyDef.GetChild(0).GetText().Replace("\"", ""), propertyDef.GetChild(2).GetText());
                            }
                        }
                    }
                }
            }
            _currentParent = (UastNode)_parentStack.Pop();
            return TRUE;
        }
        public override bool VisitAssociation_def([NotNull] DVOscarParser.Association_defContext context)
        {
            UastNode node = new UastNode();
            _currentParent.AddChild(node);
            node.Parent = _currentParent;
            foreach (var child in context.children)
            {
                if (child.GetType() == typeof(DVOscarParser.IdentifierContext))
                {
                    node.InternalType = $"dvo:Association";
                    node.Token = child.GetText();
                    node.AddRole(Role.RELATIONSHIP);
                    node.AddRole(Role.IDENTIFIER);
                }
                if (child.GetType() == typeof(DVOscarParser.CardinalityContext))
                {
                    DVOscarParser.CardinalityContext cardinality = (DVOscarParser.CardinalityContext)child;
                    foreach (var c in cardinality.children)
                    {
                        if (c.GetType() == typeof(DVOscarParser.O2oContext))
                        {
                            node.AddProperty("Cardinality", "1-2-1");
                        }
                        if (c.GetType() == typeof(DVOscarParser.M2mContext))
                        {
                            node.AddProperty("Cardinality", "M-2-M");
                        }
                        if (c.GetChild(1).GetType() == typeof(DVOscarParser.IdentifierContext))
                        {
                            node.AddProperty("Item", c.GetChild(1).GetText());
                        }
                        if (c.GetChild(2).GetType() == typeof(DVOscarParser.From_keyContext))
                        {
                            node.AddProperty("FromKey", c.GetChild(2).GetChild(1).GetText());
                        }
                        if (c.GetChild(3).GetType() == typeof(DVOscarParser.To_keyContext))
                        {
                            node.AddProperty("ToKey", c.GetChild(3).GetChild(1).GetText());
                        }
                    }
                }
                if (child.GetType() == typeof(DVOscarParser.PropertiesContext))
                {
                    DVOscarParser.PropertiesContext properties = (DVOscarParser.PropertiesContext)child;
                    foreach (DVOscarParser.PropertyContext property in properties.children)
                    {
                        foreach (var propertyDef in property.children)
                        {
                            if (propertyDef.GetType() == typeof(DVOscarParser.PairContext))
                            {
                                node.AddProperty(propertyDef.GetChild(0).GetText().Replace("\"", ""), propertyDef.GetChild(2).GetText());
                            }
                        }
                    }
                }
            }
            return TRUE;
        }
        public override bool VisitAttribute_def([NotNull] DVOscarParser.Attribute_defContext context)
        {
            UastNode node = new UastNode();
            foreach (var child in context.children)
            {
                if (child.GetType() == typeof(DVOscarParser.IdentifierContext))
                {
                    node.InternalType = $"dvo:Attribute";
                    node.Token = child.GetText();
                    node.AddRole(Role.IDENTIFIER);
                    node.Parent = _currentParent;
                    _currentParent.AddChild(node);
                }
                if (child.GetType() == typeof(DVOscarParser.Attrib_propertiesContext))
                {
                    _currentParent = node;
                    bool tf = VisitAttrib_properties((DVOscarParser.Attrib_propertiesContext)child);
                }
            }
            return TRUE;
        }
        public override bool VisitAttrib_properties([NotNull] DVOscarParser.Attrib_propertiesContext context)
        {
            UastNode node = _currentParent;
            foreach (var child in context.children)
            {
                if (child.GetType() == typeof(DVOscarParser.Display_nameContext))
                {
                    node.AddProperty("Display Name", child.GetText());
                }
                if (child.GetType() == typeof(DVOscarParser.Datatype_defContext))
                {
                    DVOscarParser.Datatype_defContext datatype = (DVOscarParser.Datatype_defContext)child;
                    node.AddProperty("Datatype", datatype.GetChild(0).GetText().ToUpper().Replace(":", ""));
                }
                if (child.GetType() == typeof(DVOscarParser.Length_defContext))
                {
                    DVOscarParser.Length_defContext length = (DVOscarParser.Length_defContext)child;
                    node.AddProperty("Length", length.GetChild(1).GetText());
                }
                if (child.GetType() == typeof(DVOscarParser.Precision_defContext))
                {
                    DVOscarParser.Precision_defContext precision = (DVOscarParser.Precision_defContext)child;
                    node.AddProperty("Precision", precision.GetChild(1).GetText());
                }
                if (child.GetType() == typeof(DVOscarParser.Scale_defContext))
                {
                    DVOscarParser.Scale_defContext scale = (DVOscarParser.Scale_defContext)child;
                    node.AddProperty("Scale", scale.GetChild(1).GetText());
                }
                if (child.GetType() == typeof(DVOscarParser.Default_valueContext))
                {
                    DVOscarParser.Default_valueContext default_ctx = (DVOscarParser.Default_valueContext)child;
                    node.AddProperty("Default", default_ctx.GetChild(1).GetText());
                }
                if (child.GetType() == typeof(DVOscarParser.PropertiesContext))
                {
                    DVOscarParser.PropertiesContext properties = (DVOscarParser.PropertiesContext)child;
                    foreach (DVOscarParser.PropertyContext property in properties.children)
                    {
                        foreach (var propertyDef in property.children)
                        {
                            if (propertyDef.GetType() == typeof(DVOscarParser.PairContext))
                            {
                                node.AddProperty(propertyDef.GetChild(0).GetText().Replace("\"", ""), propertyDef.GetChild(2).GetText());
                            }
                        }
                    }
                }
            }
            return TRUE;
        }
     }
}
