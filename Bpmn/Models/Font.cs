#nullable disable
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/DD/20100524/DC")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.omg.org/spec/DD/20100524/DC", IsNullable=false)]
public partial class Font {
    
    private string nameField;
    
    private double sizeField;
    
    private bool sizeFieldSpecified;
    
    private bool isBoldField;
    
    private bool isBoldFieldSpecified;
    
    private bool isItalicField;
    
    private bool isItalicFieldSpecified;
    
    private bool isUnderlineField;
    
    private bool isUnderlineFieldSpecified;
    
    private bool isStrikeThroughField;
    
    private bool isStrikeThroughFieldSpecified;
    
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
    public double size {
        get {
            return this.sizeField;
        }
        set {
            this.sizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sizeSpecified {
        get {
            return this.sizeFieldSpecified;
        }
        set {
            this.sizeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isBold {
        get {
            return this.isBoldField;
        }
        set {
            this.isBoldField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isBoldSpecified {
        get {
            return this.isBoldFieldSpecified;
        }
        set {
            this.isBoldFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isItalic {
        get {
            return this.isItalicField;
        }
        set {
            this.isItalicField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isItalicSpecified {
        get {
            return this.isItalicFieldSpecified;
        }
        set {
            this.isItalicFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isUnderline {
        get {
            return this.isUnderlineField;
        }
        set {
            this.isUnderlineField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isUnderlineSpecified {
        get {
            return this.isUnderlineFieldSpecified;
        }
        set {
            this.isUnderlineFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isStrikeThrough {
        get {
            return this.isStrikeThroughField;
        }
        set {
            this.isStrikeThroughField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isStrikeThroughSpecified {
        get {
            return this.isStrikeThroughFieldSpecified;
        }
        set {
            this.isStrikeThroughFieldSpecified = value;
        }
    }
}