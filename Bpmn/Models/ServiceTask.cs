/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("serviceTask", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ServiceTask : Task {
    
    private string implementationField;
    
    private System.Xml.XmlQualifiedName operationRefField;
    
    public ServiceTask() {
        this.implementationField = "##WebService";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute("##WebService")]
    public string implementation {
        get {
            return this.implementationField;
        }
        set {
            this.implementationField = value;
        }
    }
    
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
}