/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SubConversation))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Conversation))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(CallConversation))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("conversationNode", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public abstract partial class ConversationNode : BaseElement {
    
    private System.Xml.XmlQualifiedName[] participantRefField;
    
    private System.Xml.XmlQualifiedName[] messageFlowRefField;
    
    private CorrelationKey[] correlationKeyField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("participantRef")]
    public System.Xml.XmlQualifiedName[] participantRef {
        get {
            return this.participantRefField;
        }
        set {
            this.participantRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("messageFlowRef")]
    public System.Xml.XmlQualifiedName[] messageFlowRef {
        get {
            return this.messageFlowRefField;
        }
        set {
            this.messageFlowRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("correlationKey")]
    public CorrelationKey[] correlationKey {
        get {
            return this.correlationKeyField;
        }
        set {
            this.correlationKeyField = value;
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