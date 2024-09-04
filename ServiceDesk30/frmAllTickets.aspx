<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAllTickets.aspx.cs" Inherits="ServiceDesk30.frmAllTickets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <ContentTemplate>
            <main>
                <div class="page-breadcrumb d-none d-sm-flex align-items-center mb-3">
                    <div class="breadcrumb-title pe-3">Components</div>
                    <div class="ps-3">
                        <nav aria-label="breadcrumb">
                            <ol class="breadcrumb mb-0 p-0">
                                <li class="breadcrumb-item active" aria-current="page"><i class="bx bx-home-alt"></i>All Tickets</li>
                            </ol>
                        </nav>
                    </div>

                </div>
                <div class="row">
                    <div class="col-12 col-lg-12">
                        <div class="card mb-2">
                            <div class="card-body p-4">
                                <asp:Panel ID="pnlgridrow" runat="server">
                                    <div class="row">
                                        <div class="col-md-12" style="border-bottom: none">
                                            <asp:Label ID="lblheader" CssClass="headline" runat="server" Font-Size="Larger" Text="ALL Ticket"></asp:Label>
                                            <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="row gx-3">
                                        <div class="col-md-1">
                                            <label for="input1" class="form-label">Column</label>
                                            <div class="btn-group">
                                                <button type="button" class="btn  btn-outline-secondary d-flex btn-sm" data-bs-toggle="modal"
                                                    data-bs-target="#ScrollableModal">
                                                    <i class="fadeIn animated bx bx-file-blank"></i>
                                                </button>
                                                <button type="button" class="btn  btn-outline-secondary d-flex btn-sm">
                                                    <i class="fadeIn animated bx bx-filter-alt"></i>
                                                </button>
                                            </div>
                                            <!-- Modal -->
                                            <div class="modal fade" id="ScrollableModal">
                                                <div class="modal-dialog modal-dialog-centered modal-dialog-scrollable">
                                                    <div class="modal-content">
                                                        <div class="modal-header border-bottom-0 bg-grd-primary py-1">
                                                            <h6 class="modal-title">Select Colums</h6>
                                                            <a href="javascript:;" class="primaery-menu-close" data-bs-dismiss="modal">
                                                                <i class="material-icons-outlined">close</i>
                                                            </a>
                                                        </div>

                                                        <div class="modal-body">
                                                            <div class="order-summary">
                                                                <div class="card mb-0">
                                                                    <div class="card-body">
                                                                        <div class="card border bg-transparent shadow-none">
                                                                            <div class="card-body">
                                                                                <div class="row gx-5 gy-3">
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault1">
                                                                                            <label class="form-check-label" for="flexCheckDefault1">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault2">
                                                                                            <label class="form-check-label" for="flexCheckDefault2">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault3">
                                                                                            <label class="form-check-label" for="flexCheckDefault3">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault4">
                                                                                            <label class="form-check-label" for="flexCheckDefault4">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault5">
                                                                                            <label class="form-check-label" for="flexCheckDefault5">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault6">
                                                                                            <label class="form-check-label" for="flexCheckDefault6">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault7">
                                                                                            <label class="form-check-label" for="flexCheckDefault7">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault8">
                                                                                            <label class="form-check-label" for="flexCheckDefault8">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault19">
                                                                                            <label class="form-check-label" for="flexCheckDefault19">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault10">
                                                                                            <label class="form-check-label" for="flexCheckDefault10">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault11">
                                                                                            <label class="form-check-label" for="flexCheckDefault11">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault12">
                                                                                            <label class="form-check-label" for="flexCheckDefault12">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault13">
                                                                                            <label class="form-check-label" for="flexCheckDefault13">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault14">
                                                                                            <label class="form-check-label" for="flexCheckDefault14">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="col-auto">
                                                                                        <div class="form-check">
                                                                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault15">
                                                                                            <label class="form-check-label" for="flexCheckDefault15">
                                                                                                checkbox   
                                                                                            </label>
                                                                                        </div>
                                                                                    </div>
                                                                                </div>

                                                                            </div>
                                                                        </div>

                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="modal-footer border-top-0">

                                                            <button type="button" class="btn btn-sm btn-grd-primary">Next</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <%-- modal end --%>
                                        </div>
                                        <div class="col-md-3">
                                            <label for="single-select-clear-field" class="form-label">Orgainzation</label>
                                            <asp:DropDownList ID="ddlOrg" runat="server" class="form-select form-select-sm chzn-select" data-placeholder="--Choose--"></asp:DropDownList>
                                        </div>
                                        <div class="col-md-3">
                                            <label for="single-select-clear-field01" class="form-label">Request Type</label>

                                            <select class="form-select form-select-sm" id="single-select-optgroup-field" data-placeholder="Choose one thing">

                                                <optgroup label="Request Type">
                                                    <option>Change Request</option>
                                                    <option>Incident</option>
                                                    <option>Knowledge Base</option>
                                                    <option>Service Request</option>
                                                </optgroup>

                                            </select>
                                        </div>
                                        <div class="col-md-2">
                                            <label class="form-label">Action</label>
                                            <div class="btn-group">
                                                <button type="button" class="btn btn-sm btn-inverse-danger">Delete</button>

                                                <button type="button" class="btn btn-sm btn-inverse-primary">Pick Up</button>
                                            </div>
                                        </div>
                                        <div class="col-md-2">
                                            <label for="input5" class="form-label">Paging</label>
                                            <nav aria-label="Page navigation example">
                                                <ul class="pagination pagination-sm">
                                                    <li class="page-item">
                                                        <a class="page-link" href="javascript:;" aria-label="Previous"><span aria-hidden="true">«</span>
                                                        </a>
                                                    </li>
                                                    <li class="page-item"><a class="page-link" href="javascript:;">1</a>
                                                    </li>
                                                    <li class="page-item"><a class="page-link" href="javascript:;">2</a>
                                                    </li>
                                                    <li class="page-item"><a class="page-link" href="javascript:;">3</a>
                                                    </li>
                                                    <li class="page-item">
                                                        <a class="page-link" href="javascript:;" aria-label="Next"><span aria-hidden="true">»</span>
                                                        </a>
                                                    </li>
                                                </ul>
                                            </nav>
                                        </div>
                                        <div class="col-md-1">
                                            <label for="input9" class="form-label">Size</label>
                                            <select id="input9" class="form-select form-select-sm">
                                                <option selected=""></option>
                                                <option>50</option>
                                                <option>100</option>
                                                <option>150</option>
                                            </select>
                                        </div>
                                        <div class="col-md-3">
                                            <label for="input7" class="form-label">Ageing</label>
                                            <select id="input7" class="form-select form-select-sm">
                                                <option selected="">Get Tickets</option>
                                                <option>Last 1 Hour </option>
                                                <option>Last 24 Hours</option>
                                                <option>Last 30 Days</option>
                                                <option>Last 90 Days</option>
                                                <option>More than 90 Days</option>
                                            </select>
                                        </div>
                                    </div>
                                </asp:Panel>
                                <asp:Panel ID="pnlRowFilter" runat="server">
                                    <div class="row gx-3 mt-3">
                                        <div class="col-md-2">
                                            <input class="form-control form-control-sm" type="text" placeholder="Enter Ticket No.">
                                        </div>
                                        <div class="col-md-3">
                                            <input class="form-control form-control-sm" type="text" placeholder="Enter Summary">
                                        </div>
                                        <div class="col-md-2">
                                            <input class="form-control form-control-sm" type="text" placeholder="Enter Priority">
                                        </div>
                                        <div class="col-md-2">
                                            <input class="form-control form-control-sm" type="text" placeholder="Enter Severity">
                                        </div>
                                        <div class="col-md-2">
                                            <input class="form-control form-control-sm" type="text" placeholder="Enter Status">
                                        </div>
                                        <div class="col-md-1">
                                            <div class="btn-group">
                                                <button type="button" class="btn  btn-outline-secondary d-flex btn-sm" data-bs-toggle="tooltip" data-bs-placement="top" title="Go">
                                                    <i class="fadeIn animated bx bx-right-arrow"></i>
                                                </button>
                                                <button type="button" class="btn  btn-outline-secondary d-flex btn-sm" data-bs-toggle="tooltip" data-bs-placement="top" title="Remove Filter">
                                                    <i class="fadeIn animated bx bx-revision"></i>
                                                </button>
                                            </div>
                                        </div>

                                    </div>
                                </asp:Panel>
                                <div class="row mt-3 ">
                                    <div class="col-md-12">
                                        <div class="btn-group w-100">
                                            <button type="button" class="btn btn-inverse-success w-100 btn-sm">
                                                Open <span class="badge border-success text-success border bg-transparent">6</span>
                                            </button>
                                            <button type="button" class="btn btn-inverse-primary w-100 btn-sm">
                                                WIP <span class="badge border-primary text-primary border bg-transparent">6</span>
                                            </button>
                                            <button type="button" class="btn btn-inverse-info w-100 btn-sm">
                                                Assigned <span class="badge border-info text-info border bg-transparent">6</span>
                                            </button>
                                            <button type="button" class="btn btn-inverse-warning w-100 btn-sm">
                                                <%--Unassigned-Open--%> 
                                        Unmapped
                                        <span class="badge border-warning text-warning border bg-transparent">6</span>
                                            </button>
                                            <button type="button" class="btn btn-inverse-secondary w-100 btn-sm">
                                                Due Soon <span class="badge border-secondary text-secondary border bg-transparent">6</span>
                                            </button>
                                            <button type="button" class="btn btn-inverse-danger w-100 btn-sm">
                                                Overdue <span class="badge border-danger text-danger border bg-transparent">6</span>
                                            </button>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="card">
                            <div class="card-body ">
                                <div class="table-responsive">
                                    <div class="table-responsive p-0 mt-1" style="height: 400px;">
                                        <asp:GridView ID="gvAllTickets" runat="server" CssClass="table table-head-fixed text-nowrap  " DataKeyNames="ID" AllowCustomPaging="True"
                                            AutoGenerateColumns="False" OnRowCommand="gvAllTickets_RowCommand" OnRowCreated="gvAllTickets_RowCreated" OnSorting="gvAllTickets_Sorting" OnRowDataBound="gvAllTickets_RowDataBound" AllowSorting="True" OnRowEditing="gvAllTickets_RowEditing">
                                            <Columns>
                                                <asp:TemplateField HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="30" ItemStyle-Height="5px">
                                                    <HeaderTemplate>
                                                        <asp:CheckBox ID="chkAll" runat="server" onclick="grdHeaderCheckBox(this);" />
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chkRow" runat="server" />
                                                    </ItemTemplate>
                                                    <HeaderStyle HorizontalAlign="Center" />
                                                    <ItemStyle HorizontalAlign="Center" Width="30px" />
                                                </asp:TemplateField>
                                                <asp:ButtonField ButtonType="Image" CommandName="EditTicket" HeaderText="Edit" ImageUrl="~/Images/edit.png" ItemStyle-Width="5px" ItemStyle-Height="10px" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" Visible="true">
                                                    <HeaderStyle Wrap="False" />
                                                    <ItemStyle Width="20px" Height="20px" Wrap="False" />
                                                </asp:ButtonField>
                                                <asp:TemplateField HeaderText="TicketNumber" ItemStyle-Font-Size="Smaller" SortExpression="TicketNumber" Visible="true">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblTicketNumberColor" runat="server" Text='<%# Eval("color") %>' Font-Size="Smaller" Visible="false"></asp:Label>
                                                        <asp:Label ID="lblTicketNumber" runat="server" Text='<%# Eval("TicketNumber") %>' Font-Size="Smaller" Visible="true"></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="ServiceDesk" HeaderText="ServiceDesk" SortExpression="ServiceDesk" ItemStyle-Height="5px" ItemStyle-Font-Size="Smaller" Visible="true" />
                                                <asp:BoundField DataField="Summary" HeaderText="Summary" SortExpression="Summary" ItemStyle-Width="300px" HeaderStyle-Width="400px" HeaderStyle-Wrap="false" ItemStyle-Height="5px" ItemStyle-Wrap="true" ItemStyle-Font-Size="Smaller" Visible="true">
                                                    <ItemStyle Wrap="True" />
                                                </asp:BoundField>
                                                <asp:TemplateField HeaderText="Category" ItemStyle-Height="20px" SortExpression="Category" Visible="true">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblCategoryFK" runat="server" Text='<%# Eval("Category") %>' Font-Size="Smaller" Visible="false"></asp:Label>
                                                        <asp:Label ID="lblCategoryName" runat="server" Text='<%# Eval("Category") %>' Font-Size="Smaller" Visible="true"></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="CreationDate" HeaderText="CreationDate" SortExpression="CreationDate" ItemStyle-Font-Size="Smaller" ItemStyle-Height="5px" DataFormatString="{0:yyyy-MM-dd hh:mm:ss}" />
                                                <asp:BoundField DataField="Priority" HeaderText="Priority" SortExpression="Priority" ItemStyle-Font-Size="Smaller" />
                                                <asp:TemplateField HeaderText="stage " ItemStyle-Width="150" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblstagecode" runat="server" Font-Size="X-Small" CssClass=" badge badge-notifications" Text='<%# Eval("Stage") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Status " ItemStyle-Width="150" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblStatusCode" runat="server" Font-Size="X-Small" CssClass=" badge badge-notifications" ForeColor="White" BackColor='<%# System.Drawing.ColorTranslator.FromHtml(Eval("StatusColorCode").ToString())%>' Text='<%# Eval("Status") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="Severity" HeaderText="Severity" SortExpression="Severity" ItemStyle-Font-Size="Smaller" ItemStyle-Height="5px" />
                                                <asp:BoundField DataField="TechLoginName" HeaderText="Assigne" SortExpression="TechLoginName" ItemStyle-Height="5px" ItemStyle-Font-Size="Smaller" />
                                                <asp:BoundField DataField="SubmitterType" HeaderText="SubmitterType" SortExpression="SubmitterType" ItemStyle-Height="5px" ItemStyle-Font-Size="Smaller" />
                                                <asp:BoundField DataField="SubmitterName" HeaderText="SubmitterName" SortExpression="SubmitterName" ItemStyle-Height="5px" ItemStyle-Font-Size="Smaller" />
                                                <asp:BoundField DataField="SubmitterEmail" HeaderText="SubmitterEmail" SortExpression="SubmitterEmail" ItemStyle-Height="5px" ItemStyle-Font-Size="Smaller" />
                                                <asp:BoundField DataField="SubmitterPhone" HeaderText="SubmitterPhone" SortExpression="SubmitterPhone" ItemStyle-Height="5px" ItemStyle-Font-Size="Smaller" />
                                                <asp:BoundField DataField="DueDate" HeaderText="Expect. Response Dt" SortExpression="SubmitterPhone" ItemStyle-Height="5px" ItemStyle-Font-Size="Smaller" />
                                                <asp:BoundField DataField="ExpectedResolutionDt" HeaderText="Expect Resoution Dt " SortExpression="SubmitterPhone" ItemStyle-Height="5px" ItemStyle-Font-Size="Smaller" />
                                                <asp:BoundField DataField="location" HeaderText="Location " SortExpression="Location" ItemStyle-Height="5px" ItemStyle-Font-Size="Smaller" />

                                                <asp:BoundField DataField="SourceType" HeaderText="SourceType" SortExpression="SourceType" ItemStyle-Height="5px" ItemStyle-Font-Size="Smaller" />
                                            </Columns>
                                            <RowStyle BackColor="White" BorderColor="#e3e4e6" BorderWidth="1px" Height="5px" />
                                            <FooterStyle BackColor="#EDEDED" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#EDEDED" ForeColor="#000000" HorizontalAlign="Left" Height="5px" VerticalAlign="NotSet" CssClass="header" />
                                            <SelectedRowStyle BackColor="#fff" Font-Bold="True" ForeColor="#000000" Height="5px" />
                                            <HeaderStyle BackColor="#EEEEEE" Font-Bold="True" ForeColor="#414141" Height="5px" BorderColor="WhiteSmoke" CssClass="header sorting_asc" Font-Size="Small" />
                                            <EditRowStyle BackColor="#e9edf2" BorderColor="#e3e4e6" BorderStyle="Solid" BorderWidth="1px" Height="5px" />
                                            <EmptyDataRowStyle HorizontalAlign="Center" BackColor="#EDEDED" />
                                            <EmptyDataTemplate>No Record Available</EmptyDataTemplate>
                                            <AlternatingRowStyle BackColor="#EAEEFF" BorderColor="#e3e4e6" Height="5px" BorderStyle="Solid" BorderWidth="1px" />

                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!--end row-->
            </main>
        </ContentTemplate>
        <Triggers>

            <asp:PostBackTrigger ControlID="rptpageindexing" />
            <asp:AsyncPostBackTrigger ControlID="imgcolumnfilter" EventName="Click" />
            <asp:PostBackTrigger ControlID="btngetCheckcolumn" />
            <asp:PostBackTrigger ControlID="ddlGetticketFilter" />
            <asp:PostBackTrigger ControlID="ddlPageSize" />
            <asp:PostBackTrigger ControlID="btnDelteBulkTicket" />
            <asp:PostBackTrigger ControlID="gvAllTickets" />
            <asp:PostBackTrigger ControlID="imgRowFilter" />
            <asp:PostBackTrigger ControlID="ddlOrg" />
            <asp:PostBackTrigger ControlID="ddlRequestType" />
            <asp:PostBackTrigger ControlID="btnPickupTicket" />
            <asp:PostBackTrigger ControlID="btnGridFilter" />
            <asp:PostBackTrigger ControlID="btnOpenTicket" />
            <asp:PostBackTrigger ControlID="btnWipTicket" />
            <asp:PostBackTrigger ControlID="btnTicketAssigntoME" />
            <asp:PostBackTrigger ControlID="btnAssignToOther" />
            <asp:PostBackTrigger ControlID="btnDueSoonTickets" />
            <asp:PostBackTrigger ControlID="btnTicketEsclated" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
