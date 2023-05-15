/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("operation", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class Operation : BaseElement {
    
    private System.Xml.XmlQualifiedName inMessageRefField;
    
    private System.Xml.XmlQualifiedName outMessageRefField;
    
    private System.Xml.XmlQualifiedName[] errorRefField;
    
    private string nameField;
    
    private System.Xml.XmlQualifiedName implementationRefField;
    
    /// <remarks/>
    public System.Xml.XmlQualifiedName inMessageRef {
        get {
            return this.inMessageRefField;
        }
        set {
            this.inMessageRefField = value;
        }
    }
    
    /// <remarks/>
    public System.Xml.XmlQualifiedName outMessageRef {
        get {
            return this.outMessageRefField;
        }
        set {
            this.outMessageRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("errorRef")]
    public System.Xml.XmlQualifiedName[] errorRef {
        get {
            return this.errorRefField;
        }
        set {
            this.errorRefField = value;
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