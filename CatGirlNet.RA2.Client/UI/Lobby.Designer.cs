namespace CatGirlNet.RA2.Client.UI
{
    partial class Lobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            groupBoxRooms = new GroupBox();
            listBoxRooms = new ListBox();
            groupBoxChat = new GroupBox();
            labelChat = new Label();
            buttonChatSend = new Button();
            textBoxChat = new TextBox();
            listBoxChat = new ListBox();
            contextMenuStripChatMessage = new ContextMenuStrip(components);
            toolStripMenuItemCopy = new ToolStripMenuItem();
            toolStripMenuItemClear = new ToolStripMenuItem();
            groupBoxSettings = new GroupBox();
            labelPlayerName = new Label();
            groupBoxPlayers = new GroupBox();
            listBoxPlayers = new ListBox();
            groupBoxInformation = new GroupBox();
            richTextBoxInformation = new RichTextBox();
            contextMenuStripPlayer = new ContextMenuStrip(components);
            contextMenuStripRoom = new ContextMenuStrip(components);
            buttonQuit = new Button();
            textBoxPlayerName = new TextBox();
            groupBoxRooms.SuspendLayout();
            groupBoxChat.SuspendLayout();
            contextMenuStripChatMessage.SuspendLayout();
            groupBoxSettings.SuspendLayout();
            groupBoxPlayers.SuspendLayout();
            groupBoxInformation.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRooms
            // 
            resources.ApplyResources(groupBoxRooms, "groupBoxRooms");
            groupBoxRooms.Controls.Add(listBoxRooms);
            groupBoxRooms.Name = "groupBoxRooms";
            groupBoxRooms.TabStop = false;
            // 
            // listBoxRooms
            // 
            resources.ApplyResources(listBoxRooms, "listBoxRooms");
            listBoxRooms.FormattingEnabled = true;
            listBoxRooms.Name = "listBoxRooms";
            // 
            // groupBoxChat
            // 
            resources.ApplyResources(groupBoxChat, "groupBoxChat");
            groupBoxChat.Controls.Add(labelChat);
            groupBoxChat.Controls.Add(buttonChatSend);
            groupBoxChat.Controls.Add(textBoxChat);
            groupBoxChat.Controls.Add(listBoxChat);
            groupBoxChat.Name = "groupBoxChat";
            groupBoxChat.TabStop = false;
            // 
            // labelChat
            // 
            resources.ApplyResources(labelChat, "labelChat");
            labelChat.Name = "labelChat";
            // 
            // buttonChatSend
            // 
            resources.ApplyResources(buttonChatSend, "buttonChatSend");
            buttonChatSend.Name = "buttonChatSend";
            buttonChatSend.UseVisualStyleBackColor = true;
            // 
            // textBoxChat
            // 
            textBoxChat.AcceptsReturn = true;
            textBoxChat.AcceptsTab = true;
            resources.ApplyResources(textBoxChat, "textBoxChat");
            textBoxChat.Name = "textBoxChat";
            // 
            // listBoxChat
            // 
            resources.ApplyResources(listBoxChat, "listBoxChat");
            listBoxChat.FormattingEnabled = true;
            listBoxChat.Name = "listBoxChat";
            // 
            // contextMenuStripChatMessage
            // 
            resources.ApplyResources(contextMenuStripChatMessage, "contextMenuStripChatMessage");
            contextMenuStripChatMessage.ImageScalingSize = new Size(24, 24);
            contextMenuStripChatMessage.Items.AddRange(new ToolStripItem[] { toolStripMenuItemCopy, toolStripMenuItemClear });
            contextMenuStripChatMessage.Name = "contextMenuStripChat";
            // 
            // toolStripMenuItemCopy
            // 
            resources.ApplyResources(toolStripMenuItemCopy, "toolStripMenuItemCopy");
            toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            // 
            // toolStripMenuItemClear
            // 
            resources.ApplyResources(toolStripMenuItemClear, "toolStripMenuItemClear");
            toolStripMenuItemClear.Name = "toolStripMenuItemClear";
            // 
            // groupBoxSettings
            // 
            resources.ApplyResources(groupBoxSettings, "groupBoxSettings");
            groupBoxSettings.Controls.Add(textBoxPlayerName);
            groupBoxSettings.Controls.Add(labelPlayerName);
            groupBoxSettings.Name = "groupBoxSettings";
            groupBoxSettings.TabStop = false;
            // 
            // labelPlayerName
            // 
            resources.ApplyResources(labelPlayerName, "labelPlayerName");
            labelPlayerName.Name = "labelPlayerName";
            // 
            // groupBoxPlayers
            // 
            resources.ApplyResources(groupBoxPlayers, "groupBoxPlayers");
            groupBoxPlayers.Controls.Add(listBoxPlayers);
            groupBoxPlayers.Name = "groupBoxPlayers";
            groupBoxPlayers.TabStop = false;
            // 
            // listBoxPlayers
            // 
            resources.ApplyResources(listBoxPlayers, "listBoxPlayers");
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.Name = "listBoxPlayers";
            // 
            // groupBoxInformation
            // 
            resources.ApplyResources(groupBoxInformation, "groupBoxInformation");
            groupBoxInformation.Controls.Add(richTextBoxInformation);
            groupBoxInformation.Name = "groupBoxInformation";
            groupBoxInformation.TabStop = false;
            // 
            // richTextBoxInformation
            // 
            resources.ApplyResources(richTextBoxInformation, "richTextBoxInformation");
            richTextBoxInformation.Name = "richTextBoxInformation";
            richTextBoxInformation.ReadOnly = true;
            // 
            // contextMenuStripPlayer
            // 
            resources.ApplyResources(contextMenuStripPlayer, "contextMenuStripPlayer");
            contextMenuStripPlayer.ImageScalingSize = new Size(24, 24);
            contextMenuStripPlayer.Name = "contextMenuStripPlayer";
            // 
            // contextMenuStripRoom
            // 
            resources.ApplyResources(contextMenuStripRoom, "contextMenuStripRoom");
            contextMenuStripRoom.ImageScalingSize = new Size(24, 24);
            contextMenuStripRoom.Name = "contextMenuStripRoom";
            // 
            // buttonQuit
            // 
            resources.ApplyResources(buttonQuit, "buttonQuit");
            buttonQuit.Name = "buttonQuit";
            buttonQuit.UseVisualStyleBackColor = true;
            // 
            // textBoxPlayerName
            // 
            resources.ApplyResources(textBoxPlayerName, "textBoxPlayerName");
            textBoxPlayerName.Name = "textBoxPlayerName";
            // 
            // Lobby
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(buttonQuit);
            Controls.Add(groupBoxInformation);
            Controls.Add(groupBoxPlayers);
            Controls.Add(groupBoxSettings);
            Controls.Add(groupBoxChat);
            Controls.Add(groupBoxRooms);
            MaximizeBox = false;
            Name = "Lobby";
            groupBoxRooms.ResumeLayout(false);
            groupBoxChat.ResumeLayout(false);
            groupBoxChat.PerformLayout();
            contextMenuStripChatMessage.ResumeLayout(false);
            groupBoxSettings.ResumeLayout(false);
            groupBoxSettings.PerformLayout();
            groupBoxPlayers.ResumeLayout(false);
            groupBoxInformation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxRooms;
        private ListBox listBoxRooms;
        private GroupBox groupBoxChat;
        private ListBox listBoxChat;
        private ContextMenuStrip contextMenuStripChatMessage;
        private ToolStripMenuItem toolStripMenuItemCopy;
        private ToolStripMenuItem toolStripMenuItemClear;
        private GroupBox groupBoxSettings;
        private GroupBox groupBoxPlayers;
        private ListBox listBoxPlayers;
        private Button buttonChatSend;
        private TextBox textBoxChat;
        private Label labelChat;
        private GroupBox groupBoxInformation;
        private ContextMenuStrip contextMenuStripPlayer;
        private ContextMenuStrip contextMenuStripRoom;
        private Button buttonQuit;
        private RichTextBox richTextBoxInformation;
        private Label labelPlayerName;
        private TextBox textBoxPlayerName;
    }
}