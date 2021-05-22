//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from I:\DVProjects\IntuitionData\OscarAntlr\DVOscarParser.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="DVOscarParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IDVOscarParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.dvoscar_file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDvoscar_file([NotNull] DVOscarParser.Dvoscar_fileContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] DVOscarParser.BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.datastore_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatastore_statement([NotNull] DVOscarParser.Datastore_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.parent_item_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParent_item_statement([NotNull] DVOscarParser.Parent_item_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.item_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitItem_statement([NotNull] DVOscarParser.Item_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.child_item_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitChild_item_statement([NotNull] DVOscarParser.Child_item_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.associations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssociations([NotNull] DVOscarParser.AssociationsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.association_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssociation_def([NotNull] DVOscarParser.Association_defContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.cardinality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCardinality([NotNull] DVOscarParser.CardinalityContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.o2o"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitO2o([NotNull] DVOscarParser.O2oContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.m2m"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitM2m([NotNull] DVOscarParser.M2mContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.m2o"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitM2o([NotNull] DVOscarParser.M2oContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.from_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFrom_key([NotNull] DVOscarParser.From_keyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.to_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTo_key([NotNull] DVOscarParser.To_keyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.attribute_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttribute_def([NotNull] DVOscarParser.Attribute_defContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.attrib_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttrib_properties([NotNull] DVOscarParser.Attrib_propertiesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.precision_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrecision_def([NotNull] DVOscarParser.Precision_defContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.scale_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitScale_def([NotNull] DVOscarParser.Scale_defContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.length_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLength_def([NotNull] DVOscarParser.Length_defContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.default_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefault_value([NotNull] DVOscarParser.Default_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] DVOscarParser.IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.datatype_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDatatype_def([NotNull] DVOscarParser.Datatype_defContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProperties([NotNull] DVOscarParser.PropertiesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProperty([NotNull] DVOscarParser.PropertyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPair([NotNull] DVOscarParser.PairContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.display_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDisplay_name([NotNull] DVOscarParser.Display_nameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.plural"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPlural([NotNull] DVOscarParser.PluralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArray([NotNull] DVOscarParser.ArrayContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction_call([NotNull] DVOscarParser.Function_callContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArguments([NotNull] DVOscarParser.ArgumentsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgument([NotNull] DVOscarParser.ArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValue([NotNull] DVOscarParser.ValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.integer_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInteger_value([NotNull] DVOscarParser.Integer_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant([NotNull] DVOscarParser.ConstantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DVOscarParser.sign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSign([NotNull] DVOscarParser.SignContext context);
}
