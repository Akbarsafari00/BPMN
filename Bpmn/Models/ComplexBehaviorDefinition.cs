/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("complexBehaviorDefinition", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ComplexBehaviorDefinition : BaseElement {
    
    private FormalExpression conditionField;
    
    private ImplicitThrowEvent eventField;
    
    /// <remarks/>
    public FormalExpression condition {
        get {
            return this.conditionField;
        }
        set {
            this.conditionField = value;
        }
    }
    
    /// <remarks/>
    public ImplicitThrowEvent @event {
        get {
            return this.eventField;
        }
        set {
            this.eventField = value;
        }
    }
}