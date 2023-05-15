/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("definitions", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class Definitions {
    
    private Import[] importField;
    
    private Extension[] extensionField;
    
    private RootElement[] itemsField;
    
    private BPMNDiagram[] bPMNDiagramField;
    
    private Relationship[] relationshipField;
    
    private string idField;
    
    private string nameField;
    
    private string targetNamespaceField;
    
    private string expressionLanguageField;
    
    private string typeLanguageField;
    
    private string exporterField;
    
    private string exporterVersionField;
    
    private System.Xml.XmlAttribute[] anyAttrField;
    
    public Definitions() {
        this.expressionLanguageField = "http://www.w3.org/1999/XPath";
        this.typeLanguageField = "http://www.w3.org/2001/XMLSchema";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("import")]
    public Import[] import {
        get {
            return this.importField;
        }
        set {
            this.importField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("extension")]
    public Extension[] extension {
        get {
            return this.extensionField;
        }
        set {
            this.extensionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("category", typeof(Category))]
    [System.Xml.Serialization.XmlElementAttribute("collaboration", typeof(Collaboration))]
    [System.Xml.Serialization.XmlElementAttribute("correlationProperty", typeof(CorrelationProperty))]
    [System.Xml.Serialization.XmlElementAttribute("dataStore", typeof(DataStore))]
    [System.Xml.Serialization.XmlElementAttribute("endPoint", typeof(EndPoint))]
    [System.Xml.Serialization.XmlElementAttribute("error", typeof(Error))]
    [System.Xml.Serialization.XmlElementAttribute("escalation", typeof(Escalation))]
    [System.Xml.Serialization.XmlElementAttribute("eventDefinition", typeof(EventDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("globalBusinessRuleTask", typeof(GlobalBusinessRuleTask))]
    [System.Xml.Serialization.XmlElementAttribute("globalManualTask", typeof(GlobalManualTask))]
    [System.Xml.Serialization.XmlElementAttribute("globalScriptTask", typeof(GlobalScriptTask))]
    [System.Xml.Serialization.XmlElementAttribute("globalTask", typeof(GlobalTask))]
    [System.Xml.Serialization.XmlElementAttribute("globalUserTask", typeof(GlobalUserTask))]
    [System.Xml.Serialization.XmlElementAttribute("interface", typeof(Interface))]
    [System.Xml.Serialization.XmlElementAttribute("itemDefinition", typeof(ItemDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("message", typeof(Message))]
    [System.Xml.Serialization.XmlElementAttribute("partnerEntity", typeof(PartnerEntity))]
    [System.Xml.Serialization.XmlElementAttribute("partnerRole", typeof(PartnerRole))]
    [System.Xml.Serialization.XmlElementAttribute("process", typeof(Process))]
    [System.Xml.Serialization.XmlElementAttribute("resource", typeof(Resource))]
    [System.Xml.Serialization.XmlElementAttribute("rootElement", typeof(RootElement))]
    [System.Xml.Serialization.XmlElementAttribute("signal", typeof(Signal))]
    public RootElement[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BPMNDiagram", Namespace="http://www.omg.org/spec/BPMN/20100524/DI")]
    public BPMNDiagram[] BPMNDiagram {
        get {
            return this.bPMNDiagramField;
        }
        set {
            this.bPMNDiagramField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("relationship")]
    public Relationship[] relationship {
        get {
            return this.relationshipField;
        }
        set {
            this.relationshipField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
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
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string targetNamespace {
        get {
            return this.targetNamespaceField;
        }
        set {
            this.targetNamespaceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    [System.ComponentModel.DefaultValueAttribute("http://www.w3.org/1999/XPath")]
    public string expressionLanguage {
        get {
            return this.expressionLanguageField;
        }
        set {
            this.expressionLanguageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    [System.ComponentModel.DefaultValueAttribute("http://www.w3.org/2001/XMLSchema")]
    public string typeLanguage {
        get {
            return this.typeLanguageField;
        }
        set {
            this.typeLanguageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string exporter {
        get {
            return this.exporterField;
        }
        set {
            this.exporterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string exporterVersion {
        get {
            return this.exporterVersionField;
        }
        set {
            this.exporterVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr {
        get {
            return this.anyAttrField;
        }
        set {
            this.anyAttrField = value;
        }
    }
}