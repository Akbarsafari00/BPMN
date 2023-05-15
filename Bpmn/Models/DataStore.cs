/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("dataStore", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class DataStore : RootElement {
    
    private DataState dataStateField;
    
    private string nameField;
    
    private string capacityField;
    
    private bool isUnlimitedField;
    
    private System.Xml.XmlQualifiedName itemSubjectRefField;
    
    public DataStore() {
        this.isUnlimitedField = true;
    }
    
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
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string capacity {
        get {
            return this.capacityField;
        }
        set {
            this.capacityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool isUnlimited {
        get {
            return this.isUnlimitedField;
        }
        set {
            this.isUnlimitedField = value;
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
}