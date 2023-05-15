/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("correlationPropertyRetrievalExpression", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class CorrelationPropertyRetrievalExpression : BaseElement {
    
    private FormalExpression messagePathField;
    
    private System.Xml.XmlQualifiedName messageRefField;
    
    /// <remarks/>
    public FormalExpression messagePath {
        get {
            return this.messagePathField;
        }
        set {
            this.messagePathField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName messageRef {
        get {
            return this.messageRefField;
        }
        set {
            this.messageRefField = value;
        }
    }
}