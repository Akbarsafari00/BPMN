/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Process))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalUserTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalScriptTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalManualTask))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalBusinessRuleTask))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("callableElement", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class CallableElement : RootElement {
    
    private System.Xml.XmlQualifiedName[] supportedInterfaceRefField;
    
    private InputOutputSpecification ioSpecificationField;
    
    private InputOutputBinding[] ioBindingField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("supportedInterfaceRef")]
    public System.Xml.XmlQualifiedName[] supportedInterfaceRef {
        get {
            return this.supportedInterfaceRefField;
        }
        set {
            this.supportedInterfaceRefField = value;
        }
    }
    
    /// <remarks/>
    public InputOutputSpecification ioSpecification {
        get {
            return this.ioSpecificationField;
        }
        set {
            this.ioSpecificationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ioBinding")]
    public InputOutputBinding[] ioBinding {
        get {
            return this.ioBindingField;
        }
        set {
            this.ioBindingField = value;
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
}