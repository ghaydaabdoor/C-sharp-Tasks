<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="Practice_form.Form" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <title>Form</title>
</head>
<body>
    <div class="container mt-5">
        <form id="form1" runat="server">
            <div class="mb-3 row">
                <label for="inputName" class="col-sm-2 col-form-label">Name</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="inputName" CssClass="form-control" runat="server" placeholder="Name" />
                </div>
            </div>

            <div class="mb-3 row">
                <label for="inputEmail3" class="col-sm-2 col-form-label">Email</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="inputEmail" CssClass="form-control" runat="server" placeholder="Email" />
                </div>
            </div>

            <div class="mb-3 row">
                <label for="inputID" class="col-sm-2 col-form-label">ID</label>
                <div class="col-sm-10">
                    <asp:TextBox ID="inputID" CssClass="form-control" runat="server" placeholder="ID" />
                </div>
            </div>

            <fieldset class="mb-3">
                <div class="row">
                    <legend class="col-form-label col-sm-2 pt-0">Gender</legend>
                    <div class="col-sm-10">
                        <div class="form-check form-check-inline">
                            <asp:RadioButton ID="male" GroupName="gender" runat="server" />
                            <label class="form-check-label" for="male">
                                Male
                            </label>
                        </div>
                        <div class="form-check form-check-inline">
                            <asp:RadioButton ID="female" GroupName="gender" runat="server" />
                            <label class="form-check-label" for="female">
                                Female
                            </label>
                        </div>
                    </div>
                </div>
            </fieldset>

            <div class="mb-3 row">
                <label class="col-sm-2 col-form-label">Skills</label>
                <div class="col-sm-10">
                    <div class="form-check form-check-inline">
                        <asp:CheckBox ID="C" runat="server" />
                        <label class="form-check-label" for="chkC">C</label>
                    </div>
                    <div class="form-check form-check-inline">
                        <asp:CheckBox ID="Cplus" runat="server" />
                        <label class="form-check-label" for="chkCpp">C++</label>
                    </div>
                    <div class="form-check form-check-inline">
                        <asp:CheckBox ID="Csharp" runat="server" />
                        <label class="form-check-label" for="chkCsharp">C#</label>
                    </div>
                </div>
            </div>

            <div class="mb-3 row">
                <label for="inputDescription" class="col-sm-2 col-form-label">Description</label>
                <div class="col-sm-10">
                    <textarea class="form-control" id="inputDescription" placeholder="Description" rows="3" runat="server"></textarea>
                </div>
            </div>

            <div class="mb-3 row">
                <div class="col-sm-10 offset-sm-2">
                    <asp:Button ID="submitBtn" CssClass="btn btn-primary" Text="Submit" OnClick="SubmitBtn_Click" runat="server" />
                </div>
            </div>
        </form>



        <div class="mt-5">
            <h3>Submitted Data</h3>
            <p>
                <strong>Name:</strong>
                <asp:Label ID="displayName" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <strong>Email:</strong>
                <asp:Label ID="displayEmail" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <strong>ID:</strong>
                <asp:Label ID="displayID" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <strong>Gender:</strong>
                <asp:Label ID="displayGender" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <strong>Skills:</strong>
                <asp:Label ID="displaySkills" runat="server" Text=""></asp:Label>
            </p>
            <p>
                <strong>Description:</strong>
                <asp:Label ID="displayDescription" runat="server" Text=""></asp:Label>
            </p>
        </div>
    </div>
</body>
</html>

