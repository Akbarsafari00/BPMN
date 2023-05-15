/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("ioBinding", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class InputOutputBinding : BaseElement {
    
    private System.Xml.XmlQualifiedName operationRefField;
    
    private string inputDataRefField;
    
    private string outputDataRefField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName operationRef {
        get {
            return this.operationRefField;
        }
        set {
            this.operationRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
    public string inputDataRef {
        get {
            return this.inputDataRefField;
        }
        set {
            this.inputDataRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
    public string outputDataRef {
        get {
            return this.outputDataRefField;
        }
        set {
            this.outputDataRefField = value;
        }
    }
}