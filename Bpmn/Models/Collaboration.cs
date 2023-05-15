/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalConversation))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(Choreography))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(GlobalChoreographyTask))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL")]
[System.Xml.Serialization.XmlRootAttribute("collaboration", Namespace="http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable=false)]
public partial class Collaboration : RootElement {
    
    private Participant[] participantField;
    
    private MessageFlow[] messageFlowField;
    
    private Artifact[] itemsField;
    
    private ConversationNode[] items1Field;
    
    private ConversationAssociation[] conversationAssociationField;
    
    private ParticipantAssociation[] participantAssociationField;
    
    private MessageFlowAssociation[] messageFlowAssociationField;
    
    private CorrelationKey[] correlationKeyField;
    
    private System.Xml.XmlQualifiedName[] choreographyRefField;
    
    private ConversationLink[] conversationLinkField;
    
    private string nameField;
    
    private bool isClosedField;
    
    public Collaboration() {
        this.isClosedField = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("participant")]
    public Participant[] participant {
        get {
            return this.participantField;
        }
        set {
            this.participantField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("messageFlow")]
    public MessageFlow[] messageFlow {
        get {
            return this.messageFlowField;
        }
        set {
            this.messageFlowField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("artifact", typeof(Artifact))]
    [System.Xml.Serialization.XmlElementAttribute("association", typeof(Association))]
    [System.Xml.Serialization.XmlElementAttribute("group", typeof(Group))]
    [System.Xml.Serialization.XmlElementAttribute("textAnnotation", typeof(TextAnnotation))]
    public Artifact[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("callConversation", typeof(CallConversation))]
    [System.Xml.Serialization.XmlElementAttribute("conversation", typeof(Conversation))]
    [System.Xml.Serialization.XmlElementAttribute("conversationNode", typeof(ConversationNode))]
    [System.Xml.Serialization.XmlElementAttribute("subConversation", typeof(SubConversation))]
    public ConversationNode[] Items1 {
        get {
            return this.items1Field;
        }
        set {
            this.items1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("conversationAssociation")]
    public ConversationAssociation[] conversationAssociation {
        get {
            return this.conversationAssociationField;
        }
        set {
            this.conversationAssociationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("participantAssociation")]
    public ParticipantAssociation[] participantAssociation {
        get {
            return this.participantAssociationField;
        }
        set {
            this.participantAssociationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("messageFlowAssociation")]
    public MessageFlowAssociation[] messageFlowAssociation {
        get {
            return this.messageFlowAssociationField;
        }
        set {
            this.messageFlowAssociationField = value;
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
    [System.Xml.Serialization.XmlElementAttribute("choreographyRef")]
    public System.Xml.XmlQualifiedName[] choreographyRef {
        get {
            return this.choreographyRefField;
        }
        set {
            this.choreographyRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("conversationLink")]
    public ConversationLink[] conversationLink {
        get {
            return this.conversationLinkField;
        }
        set {
            this.conversationLinkField = value;
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
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool isClosed {
        get {
            return this.isClosedField;
        }
        set {
            this.isClosedField = value;
        }
    }
}