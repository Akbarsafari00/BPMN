/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("interface", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class Interface : RootElement {
    
    private Operation[] operationField;
    
    private string nameField;
    
    private System.Xml.XmlQualifiedName implementationRefField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("operation")]
    public Operation[] operation {
        get {
            return this.operationField;
        }
        set {
            this.operationField = value;
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
    public System.Xml.XmlQualifiedName implementationRef {
        get {
            return this.implementationRefField;
        }
        set {
            this.implementationRefField = value;
        }
    }
}