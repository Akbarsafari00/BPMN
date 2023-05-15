/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("receiveTask", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ReceiveTask : Task {
    
    private string implementationField;
    
    private bool instantiateField;
    
    private System.Xml.XmlQualifiedName messageRefField;
    
    private System.Xml.XmlQualifiedName operationRefField;
    
    public ReceiveTask() {
        this.implementationField = "##WebService";
        this.instantiateField = false;
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
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool instantiate {
        get {
            return this.instantiateField;
        }
        set {
            this.instantiateField = value;
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