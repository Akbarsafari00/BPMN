/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("dataObjectReference", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class DataObjectReference : FlowElement {
    
    private DataState dataStateField;
    
    private System.Xml.XmlQualifiedName itemSubjectRefField;
    
    private string dataObjectRefField;
    
    /// <remarks/>
    public DataState dataState {
        get {
            return this.dataStateField;
        }
        set {
            this.dataStateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName itemSubjectRef {
        get {
            return this.itemSubjectRefField;
        }
        set {
            this.itemSubjectRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
    public string dataObjectRef {
        get {
            return this.dataObjectRefField;
        }
        set {
            this.dataObjectRefField = value;
        }
    }
}