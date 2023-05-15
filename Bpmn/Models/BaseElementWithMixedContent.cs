/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Expression))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FormalExpression))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("baseElementWithMixedContent", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public abstract partial class BaseElementWithMixedContent {
    
    private Documentation[] documentationField;
    
    private ExtensionElements extensionElementsField;
    
    private string[] textField;
    
    private string idField;
    
    private System.Xml.XmlAttribute[] anyAttrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("documentation")]
    public Documentation[] documentation {
        get {
            return this.documentationField;
        }
        set {
            this.documentationField = value;
        }
    }
    
    /// <remarks/>
    public ExtensionElements extensionElements {
        get {
            return this.extensionElementsField;
        }
        set {
            this.extensionElementsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
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