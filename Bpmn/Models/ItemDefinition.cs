/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("itemDefinition", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class ItemDefinition : RootElement {
    
    private System.Xml.XmlQualifiedName structureRefField;
    
    private bool isCollectionField;
    
    private ItemKind itemKindField;
    
    public ItemDefinition() {
        this.isCollectionField = false;
        this.itemKindField = ItemKind.Information;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName structureRef {
        get {
            return this.structureRefField;
        }
        set {
            this.structureRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool isCollection {
        get {
            return this.isCollectionField;
        }
        set {
            this.isCollectionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(ItemKind.Information)]
    public ItemKind itemKind {
        get {
            return this.itemKindField;
        }
        set {
            this.itemKindField = value;
        }
    }
}