/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("conditionalEventDefinition", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ConditionalEventDefinition : EventDefinition {
    
    private Expression conditionField;
    
    /// <remarks/>
    public Expression condition {
        get {
            return this.conditionField;
        }
        set {
            this.conditionField = value;
        }
    }
}