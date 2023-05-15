/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("correlationPropertyBinding", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class CorrelationPropertyBinding : BaseElement {
    
    private FormalExpression dataPathField;
    
    private System.Xml.XmlQualifiedName correlationPropertyRefField;
    
    /// <remarks/>
    public FormalExpression dataPath {
        get {
            return this.dataPathField;
        }
        set {
            this.dataPathField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName correlationPropertyRef {
        get {
            return this.correlationPropertyRefField;
        }
        set {
            this.correlationPropertyRefField = value;
        }
    }
}