namespace CatGirlNet.RA2.Client;

partial class GameRoom
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameRoom));
        GroupBoxGameRule = new GroupBox();
        GroupBoxMapSelection = new GroupBox();
        LabelMapPreview = new Label();
        ListBoxMaps = new ListBox();
        GroupBoxPlayers = new GroupBox();
        ComboBoxLocation1 = new ComboBox();
        LabelLocation = new Label();
        ComboBoxTeam1 = new ComboBox();
        LabelTeam = new Label();
        ComboBoxColor1 = new ComboBox();
        LabelColor = new Label();
        ComboBoxCountry1 = new ComboBox();
        LabelCountry = new Label();
        TextBoxPlayerId1 = new TextBox();
        LabelPlayerId = new Label();
        ToolTipRoom = new ToolTip(components);
        label1 = new Label();
        GroupBoxMapSelection.SuspendLayout();
        GroupBoxPlayers.SuspendLayout();
        SuspendLayout();
        // 
        // GroupBoxGameRule
        // 
        resources.ApplyResources(GroupBoxGameRule, "GroupBoxGameRule");
        GroupBoxGameRule.Name = "GroupBoxGameRule";
        GroupBoxGameRule.TabStop = false;
        ToolTipRoom.SetToolTip(GroupBoxGameRule, resources.GetString("GroupBoxGameRule.ToolTip"));
        // 
        // GroupBoxMapSelection
        // 
        resources.ApplyResources(GroupBoxMapSelection, "GroupBoxMapSelection");
        GroupBoxMapSelection.Controls.Add(LabelMapPreview);
        GroupBoxMapSelection.Controls.Add(ListBoxMaps);
        GroupBoxMapSelection.Name = "GroupBoxMapSelection";
        GroupBoxMapSelection.TabStop = false;
        ToolTipRoom.SetToolTip(GroupBoxMapSelection, resources.GetString("GroupBoxMapSelection.ToolTip"));
        // 
        // LabelMapPreview
        // 
        resources.ApplyResources(LabelMapPreview, "LabelMapPreview");
        LabelMapPreview.Name = "LabelMapPreview";
        ToolTipRoom.SetToolTip(LabelMapPreview, resources.GetString("LabelMapPreview.ToolTip"));
        // 
        // ListBoxMaps
        // 
        resources.ApplyResources(ListBoxMaps, "ListBoxMaps");
        ListBoxMaps.FormattingEnabled = true;
        ListBoxMaps.Name = "ListBoxMaps";
        ToolTipRoom.SetToolTip(ListBoxMaps, resources.GetString("ListBoxMaps.ToolTip"));
        // 
        // GroupBoxPlayers
        // 
        resources.ApplyResources(GroupBoxPlayers, "GroupBoxPlayers");
        GroupBoxPlayers.Controls.Add(label1);
        GroupBoxPlayers.Controls.Add(ComboBoxLocation1);
        GroupBoxPlayers.Controls.Add(LabelLocation);
        GroupBoxPlayers.Controls.Add(ComboBoxTeam1);
        GroupBoxPlayers.Controls.Add(LabelTeam);
        GroupBoxPlayers.Controls.Add(ComboBoxColor1);
        GroupBoxPlayers.Controls.Add(LabelColor);
        GroupBoxPlayers.Controls.Add(ComboBoxCountry1);
        GroupBoxPlayers.Controls.Add(LabelCountry);
        GroupBoxPlayers.Controls.Add(TextBoxPlayerId1);
        GroupBoxPlayers.Controls.Add(LabelPlayerId);
        GroupBoxPlayers.Name = "GroupBoxPlayers";
        GroupBoxPlayers.TabStop = false;
        ToolTipRoom.SetToolTip(GroupBoxPlayers, resources.GetString("GroupBoxPlayers.ToolTip"));
        // 
        // ComboBoxLocation1
        // 
        resources.ApplyResources(ComboBoxLocation1, "ComboBoxLocation1");
        ComboBoxLocation1.FormattingEnabled = true;
        ComboBoxLocation1.Name = "ComboBoxLocation1";
        ToolTipRoom.SetToolTip(ComboBoxLocation1, resources.GetString("ComboBoxLocation1.ToolTip"));
        // 
        // LabelLocation
        // 
        resources.ApplyResources(LabelLocation, "LabelLocation");
        LabelLocation.Name = "LabelLocation";
        ToolTipRoom.SetToolTip(LabelLocation, resources.GetString("LabelLocation.ToolTip"));
        // 
        // ComboBoxTeam1
        // 
        resources.ApplyResources(ComboBoxTeam1, "ComboBoxTeam1");
        ComboBoxTeam1.FormattingEnabled = true;
        ComboBoxTeam1.Name = "ComboBoxTeam1";
        ToolTipRoom.SetToolTip(ComboBoxTeam1, resources.GetString("ComboBoxTeam1.ToolTip"));
        // 
        // LabelTeam
        // 
        resources.ApplyResources(LabelTeam, "LabelTeam");
        LabelTeam.Name = "LabelTeam";
        ToolTipRoom.SetToolTip(LabelTeam, resources.GetString("LabelTeam.ToolTip"));
        // 
        // ComboBoxColor1
        // 
        resources.ApplyResources(ComboBoxColor1, "ComboBoxColor1");
        ComboBoxColor1.FormattingEnabled = true;
        ComboBoxColor1.Name = "ComboBoxColor1";
        ToolTipRoom.SetToolTip(ComboBoxColor1, resources.GetString("ComboBoxColor1.ToolTip"));
        // 
        // LabelColor
        // 
        resources.ApplyResources(LabelColor, "LabelColor");
        LabelColor.Name = "LabelColor";
        ToolTipRoom.SetToolTip(LabelColor, resources.GetString("LabelColor.ToolTip"));
        // 
        // ComboBoxCountry1
        // 
        resources.ApplyResources(ComboBoxCountry1, "ComboBoxCountry1");
        ComboBoxCountry1.FormattingEnabled = true;
        ComboBoxCountry1.Name = "ComboBoxCountry1";
        ToolTipRoom.SetToolTip(ComboBoxCountry1, resources.GetString("ComboBoxCountry1.ToolTip"));
        // 
        // LabelCountry
        // 
        resources.ApplyResources(LabelCountry, "LabelCountry");
        LabelCountry.Name = "LabelCountry";
        ToolTipRoom.SetToolTip(LabelCountry, resources.GetString("LabelCountry.ToolTip"));
        // 
        // TextBoxPlayerId1
        // 
        resources.ApplyResources(TextBoxPlayerId1, "TextBoxPlayerId1");
        TextBoxPlayerId1.Name = "TextBoxPlayerId1";
        ToolTipRoom.SetToolTip(TextBoxPlayerId1, resources.GetString("TextBoxPlayerId1.ToolTip"));
        // 
        // LabelPlayerId
        // 
        resources.ApplyResources(LabelPlayerId, "LabelPlayerId");
        LabelPlayerId.Name = "LabelPlayerId";
        ToolTipRoom.SetToolTip(LabelPlayerId, resources.GetString("LabelPlayerId.ToolTip"));
        // 
        // label1
        // 
        resources.ApplyResources(label1, "label1");
        label1.Name = "label1";
        ToolTipRoom.SetToolTip(label1, resources.GetString("label1.ToolTip"));
        // 
        // GameRoom
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(GroupBoxPlayers);
        Controls.Add(GroupBoxMapSelection);
        Controls.Add(GroupBoxGameRule);
        MaximizeBox = false;
        Name = "GameRoom";
        ToolTipRoom.SetToolTip(this, resources.GetString("$this.ToolTip"));
        GroupBoxMapSelection.ResumeLayout(false);
        GroupBoxMapSelection.PerformLayout();
        GroupBoxPlayers.ResumeLayout(false);
        GroupBoxPlayers.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox GroupBoxGameRule;
    private GroupBox GroupBoxMapSelection;
    private GroupBox GroupBoxPlayers;
    private ListBox ListBoxMaps;
    private ToolTip ToolTipRoom;
    private Label LabelMapPreview;
    private Label LabelPlayerId;
    private TextBox TextBoxPlayerId1;
    private Label LabelCountry;
    private ComboBox ComboBoxCountry1;
    private ComboBox ComboBoxColor1;
    private Label LabelColor;
    private ComboBox ComboBoxTeam1;
    private Label LabelTeam;
    private ComboBox ComboBoxLocation1;
    private Label LabelLocation;
    private Label label1;
}