/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("correlationProperty", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class CorrelationProperty : RootElement {
    
    private CorrelationPropertyRetrievalExpression[] correlationPropertyRetrievalExpressionField;
    
    private string nameField;
    
    private System.Xml.XmlQualifiedName typeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("correlationPropertyRetrievalExpression")]
    public CorrelationPropertyRetrievalExpression[] correlationPropertyRetrievalExpression {
        get {
            return this.correlationPropertyRetrievalExpressionField;
        }
        set {
            this.correlationPropertyRetrievalExpressionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}