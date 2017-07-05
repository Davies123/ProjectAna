﻿namespace ANAConversationPlatform.Models
{
    public class Button : BaseEntity
    {
        public Button() { }
        public Button(string id = "", string buttonName = "", string buttonText = "", EmotionEnum emotion = EmotionEnum.Cool, ButtonTypeEnum buttonType = ButtonTypeEnum.None, string nextNodeId = "", bool defaultButton = false, bool hidden = false, string variableValue = "")
        {
            this._id = id;
            this.ButtonName = buttonName;
            this.ButtonText = buttonText;
            this.Emotion = emotion;
            this.ButtonType = buttonType;
            this.NextNodeId = nextNodeId;
            this.DefaultButton = defaultButton;
            this.Hidden = hidden;
            this.VariableValue = variableValue;
        }

        public string ButtonName { get; set; }
        public string ButtonText { get; set; }
        public EmotionEnum Emotion { get; set; }
        public ButtonTypeEnum ButtonType { get; set; }
        public string DeepLinkUrl { get; set; }
        public string Url { get; set; }
        public int? BounceTimeout { get; set; }
        public string NextNodeId { get; set; }
        public bool DefaultButton { get; set; }
        public bool Hidden { get; set; }
        public string VariableValue { get; set; }
        public string PrefixText { get; set; }
        public string PostfixText { get; set; }
        public string PlaceholderText { get; set; }

        public string APIResponseMatchKey { get; set; }
        public string APIResponseMatchValue { get; set; }

        public bool PostToChat { get; set; } = true;
    }
    public enum ButtonTypeEnum
    {
        None,
        PostText,
        OpenUrl,
        GetText,
        GetAddress,
        GetNumber,
        GetPhoneNumber,
        GetEmail,
        GetImage,
        GetAudio,
        GetVideo,
        GetItemFromSource,
        NextNode,
        DeepLink,
        GetAgent,
        ApiCall,
        ShowConfirmation
    }
}