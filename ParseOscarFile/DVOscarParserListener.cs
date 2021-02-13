//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from DVOscarParser.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="DVOscarParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IDVOscarParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.dvoscar_file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDvoscar_file([NotNull] DVOscarParser.Dvoscar_fileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.dvoscar_file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDvoscar_file([NotNull] DVOscarParser.Dvoscar_fileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] DVOscarParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] DVOscarParser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.datastore_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatastore_statement([NotNull] DVOscarParser.Datastore_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.datastore_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatastore_statement([NotNull] DVOscarParser.Datastore_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.parent_item_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParent_item_statement([NotNull] DVOscarParser.Parent_item_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.parent_item_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParent_item_statement([NotNull] DVOscarParser.Parent_item_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.item_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterItem_statement([NotNull] DVOscarParser.Item_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.item_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitItem_statement([NotNull] DVOscarParser.Item_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.child_item_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChild_item_statement([NotNull] DVOscarParser.Child_item_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.child_item_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChild_item_statement([NotNull] DVOscarParser.Child_item_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.associations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssociations([NotNull] DVOscarParser.AssociationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.associations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssociations([NotNull] DVOscarParser.AssociationsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.association_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssociation_def([NotNull] DVOscarParser.Association_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.association_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssociation_def([NotNull] DVOscarParser.Association_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.cardinality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCardinality([NotNull] DVOscarParser.CardinalityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.cardinality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCardinality([NotNull] DVOscarParser.CardinalityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.o2o"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterO2o([NotNull] DVOscarParser.O2oContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.o2o"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitO2o([NotNull] DVOscarParser.O2oContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.m2m"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterM2m([NotNull] DVOscarParser.M2mContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.m2m"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitM2m([NotNull] DVOscarParser.M2mContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.from_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrom_key([NotNull] DVOscarParser.From_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.from_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrom_key([NotNull] DVOscarParser.From_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.to_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTo_key([NotNull] DVOscarParser.To_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.to_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTo_key([NotNull] DVOscarParser.To_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.attribute_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute_def([NotNull] DVOscarParser.Attribute_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.attribute_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute_def([NotNull] DVOscarParser.Attribute_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.attrib_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttrib_properties([NotNull] DVOscarParser.Attrib_propertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.attrib_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttrib_properties([NotNull] DVOscarParser.Attrib_propertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.precision_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrecision_def([NotNull] DVOscarParser.Precision_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.precision_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrecision_def([NotNull] DVOscarParser.Precision_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.scale_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScale_def([NotNull] DVOscarParser.Scale_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.scale_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScale_def([NotNull] DVOscarParser.Scale_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.length_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLength_def([NotNull] DVOscarParser.Length_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.length_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLength_def([NotNull] DVOscarParser.Length_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.default_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefault_value([NotNull] DVOscarParser.Default_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.default_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefault_value([NotNull] DVOscarParser.Default_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] DVOscarParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] DVOscarParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.datatype_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatatype_def([NotNull] DVOscarParser.Datatype_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.datatype_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatatype_def([NotNull] DVOscarParser.Datatype_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProperties([NotNull] DVOscarParser.PropertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProperties([NotNull] DVOscarParser.PropertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProperty([NotNull] DVOscarParser.PropertyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProperty([NotNull] DVOscarParser.PropertyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPair([NotNull] DVOscarParser.PairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.pair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPair([NotNull] DVOscarParser.PairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.display_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDisplay_name([NotNull] DVOscarParser.Display_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.display_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDisplay_name([NotNull] DVOscarParser.Display_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.plural"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlural([NotNull] DVOscarParser.PluralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.plural"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlural([NotNull] DVOscarParser.PluralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArray([NotNull] DVOscarParser.ArrayContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArray([NotNull] DVOscarParser.ArrayContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_call([NotNull] DVOscarParser.Function_callContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_call([NotNull] DVOscarParser.Function_callContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArguments([NotNull] DVOscarParser.ArgumentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArguments([NotNull] DVOscarParser.ArgumentsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgument([NotNull] DVOscarParser.ArgumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgument([NotNull] DVOscarParser.ArgumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] DVOscarParser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] DVOscarParser.ValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.integer_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInteger_value([NotNull] DVOscarParser.Integer_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.integer_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInteger_value([NotNull] DVOscarParser.Integer_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] DVOscarParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] DVOscarParser.ConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DVOscarParser.sign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSign([NotNull] DVOscarParser.SignContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DVOscarParser.sign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSign([NotNull] DVOscarParser.SignContext context);
}
