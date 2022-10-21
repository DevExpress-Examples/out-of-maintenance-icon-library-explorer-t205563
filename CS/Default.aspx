<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" EnableViewState="false" ViewStateMode="Disabled" %>

<%@ Register Assembly="DevExpress.Web.v18.2, Version=18.2.18.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr style="width: 100%">
                <td style="width: 100%">
                    <dx:ASPxCheckBox ID="cbEndless" runat="server" Theme="Moderno" AutoPostBack="false"
                        Text="Enable Endless Paging Mode">
                        <ClientSideEvents CheckedChanged="function(s, e){ clbPanel.PerformCallback('changePagerMode'); }" />
                    </dx:ASPxCheckBox>
                </td>
                <td>
                    <dx:ASPxButton ID="clearSettings" runat="server" Text="Reset all"
                        AutoPostBack="false" ToolTip="Remove all filtering, sorting and grouping">
                        <ClientSideEvents Click="function(s, e){ grid.PerformCallback('clear'); }" />
                    </dx:ASPxButton>
                </td>
            </tr>
        </table>
        <dx:ASPxCallbackPanel ID="clbPanel" runat="server" ClientInstanceName="clbPanel" OnCallback="clbPanel_Callback"> 
            <PanelCollection>
                <dx:PanelContent runat="server">
                    <dx:ASPxGridView ID="gridView" runat="server" ClientInstanceName="grid" AutoGenerateColumns="false"
                        KeyFieldName="FullIconID" Width="100%" OnCustomCallback="gridView_CustomCallback" EnableViewState="false" OnHtmlDataCellPrepared="gridView_HtmlDataCellPrepared">
                        <Settings ShowHeaderFilterButton="true" VerticalScrollableHeight="400" ShowGroupPanel="true" GroupFormat="{1}{2}" ShowFooter="true" />
                        <SettingsSearchPanel Visible="true" />
                        <SettingsPager Mode="ShowPager" PageSize="15"></SettingsPager>
                        <SettingsBehavior AllowFixedGroups="true" />
                        <SettingsCookies Enabled="true" StoreFiltering="true" StoreGroupingAndSorting="true" StoreColumnsVisiblePosition="true"
                            StorePaging="true" StoreColumnsWidth="false" StoreControlWidth="false" />
                        <Columns>
                            <dx:GridViewDataImageColumn VisibleIndex="0" Name="ImageColumn" Caption="Icon" Width="40">
                                <Settings AllowGroup="False" />
                                <DataItemTemplate>
                                    <dx:ASPxImage ID="ASPxImage1" runat="server" EmptyImage-IconID='<%#Eval("FullIconID") %>'></dx:ASPxImage>
                                </DataItemTemplate>
                            </dx:GridViewDataImageColumn>
                            <dx:GridViewDataTextColumn FieldName="FullIconID" VisibleIndex="1" Width="350">
                                <Settings AllowHeaderFilter="False" AllowGroup="False" />
                                <DataItemTemplate>
                                    <dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Width="100%" Text='<%#Eval("FullIconID") %>' ReadOnly="true">
                                        <ClientSideEvents GotFocus="function(s, e){ s.SelectAll(); }" />
                                    </dx:ASPxTextBox>
                                </DataItemTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataComboBoxColumn FieldName="Category" VisibleIndex="2" Width="150">
                            </dx:GridViewDataComboBoxColumn>
                            <dx:GridViewDataTextColumn FieldName="IconName" VisibleIndex="3">
                                <Settings AllowHeaderFilter="False" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="EnumName" VisibleIndex="4">
                                <Settings AllowHeaderFilter="False" AllowGroup="False" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Collection" VisibleIndex="5" Width="100">
                                <Settings HeaderFilterMode="CheckedList" />
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Size" VisibleIndex="6" Width="60">
                                <Settings HeaderFilterMode="CheckedList" />
                            </dx:GridViewDataTextColumn>
                        </Columns>
                        <GroupSummary>
                            <dx:ASPxSummaryItem SummaryType="Count" />
                        </GroupSummary>
                        <TotalSummary>
                            <dx:ASPxSummaryItem FieldName="FullIconID" SummaryType="Count" />
                        </TotalSummary>
                        <Styles>
                            <Header HorizontalAlign="Center"></Header>
                            <AlternatingRow Enabled="True"></AlternatingRow>
                        </Styles>
                    </dx:ASPxGridView>
                </dx:PanelContent>
            </PanelCollection>
        </dx:ASPxCallbackPanel>
    </form>
</body>
</html>
