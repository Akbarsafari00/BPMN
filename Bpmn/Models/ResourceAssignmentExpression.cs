/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("resourceAssignmentExpression", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ResourceAssignmentExpression : BaseElement {
    
    private Expression itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("expression", typeof(Expression))]
    [System.Xml.Serialization.XmlElementAttribute("formalExpression", typeof(FormalExpression))]
    public Expression Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}