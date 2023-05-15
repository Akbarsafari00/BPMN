/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("resourceParameterBinding", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ResourceParameterBinding : BaseElement {
    
    private Expression itemField;
    
    private System.Xml.XmlQualifiedName parameterRefField;
    
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName parameterRef {
        get {
            return this.parameterRefField;
        }
        set {
            this.parameterRefField = value;
        }
    }
}