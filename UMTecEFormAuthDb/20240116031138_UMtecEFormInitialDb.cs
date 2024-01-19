using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UMtecEForm.Migrations.UMTecEFormAuthDb
{
    public partial class UMtecEFormInitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for Event")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Event_name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Event Name"),
                    Event_date = table.Column<DateTime>(type: "date", nullable: true, comment: "Event date"),
                    Event_time = table.Column<TimeSpan>(type: "time", nullable: true, comment: "Event time"),
                    Event_duration = table.Column<TimeSpan>(type: "time", nullable: true, comment: "Event duration"),
                    Event_venue = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Event Venue"),
                    Expected_attendees_no = table.Column<int>(type: "int", nullable: true, comment: "Expected number of Attendees"),
                    Event_objective = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Briefly describe the purpose and goals of the event"),
                    Event_description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Provide a detailed description of the event, including the agenda or program"),
                    Event_requirements = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Specify any specific equipment, facilities, or resources needed for the event"),
                    Event_budget = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Provide an estimated budget for the event, including any allocated funds or sponsorship"),
                    Event_team = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Identify the individuals, departments and association involved in organizing the event"),
                    Previous_event_info = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Specify any previous event information, including venue, number of attendees, etc."),
                    Event_promotion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Specify any marketing or promotional activities planned for the event"),
                    Additional_notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Include any additional information or special requests related to the event"),
                    Event_No = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Event Number generated after submitted"),
                    PI_Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "PI NAME"),
                    PI_Faculty = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "PI Faculty"),
                    Contact = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Contact TEL OR EXT"),
                    Budget_info = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Budget information"),
                    Start_date = table.Column<DateTime>(type: "date", nullable: true, comment: "Event StartDate"),
                    End_date = table.Column<DateTime>(type: "date", nullable: true, comment: "Event EndDate")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Event_Re__3214EC07857F4894", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PRAProposals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key of application form")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Project_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Project no", collation: "Chinese_PRC_CI_AS"),
                    PR_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "PR no ", collation: "Chinese_PRC_CI_AS"),
                    Requester_name = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true, comment: "Requester Name", collation: "Chinese_PRC_CI_AS"),
                    Requester_pname = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true, comment: "Requester Print Name", collation: "Chinese_PRC_CI_AS"),
                    Requester_email = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true, comment: "Requester email", collation: "Chinese_PRC_CI_AS"),
                    Contact_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Requester Contact Name", collation: "Chinese_PRC_CI_AS"),
                    Endorse_pname = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true, comment: "Endorsement print name", collation: "Chinese_PRC_CI_AS"),
                    Endorse_email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Endorsement Email", collation: "Chinese_PRC_CI_AS"),
                    Quotation = table.Column<int>(type: "int", nullable: true, comment: "Quotations from the suppliers 1 for have 0 for not"),
                    Approved_proposal = table.Column<int>(type: "int", nullable: true, comment: "Approved proposal (must be attached for project expenditure) 1 for have 0 for not"),
                    Other_info = table.Column<int>(type: "int", nullable: true, comment: "Other relavent information 1 for have 0 for not have."),
                    Status = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "status if in progress, ", collation: "Chinese_PRC_CI_AS"),
                    Last_modified_by = table.Column<int>(type: "int", nullable: true, comment: "Last_modified by account"),
                    Last_modified_time = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "When Last modified"),
                    Has_approved_proposal = table.Column<bool>(type: "bit", nullable: true, comment: "1 for have 0 for not"),
                    Has_participants_list = table.Column<bool>(type: "bit", nullable: true, comment: "1 for have 0 for not"),
                    Has_other_info = table.Column<bool>(type: "bit", nullable: true, comment: "1 for have 0 for not"),
                    Approved_date = table.Column<DateTime>(type: "date", nullable: true, comment: "When Approved")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PRAPropo__3214EC07F5E6D9C9", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PRAsubProposals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key of application form")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Project_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Project no", collation: "Chinese_PRC_CI_AS"),
                    PR_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "PR no ", collation: "Chinese_PRC_CI_AS"),
                    Requester_name = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true, comment: "Requester Name", collation: "Chinese_PRC_CI_AS"),
                    Requester_pname = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true, comment: "Requester Print Name", collation: "Chinese_PRC_CI_AS"),
                    Requester_email = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true, comment: "Requester email", collation: "Chinese_PRC_CI_AS"),
                    Contact_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Requester Contact Name", collation: "Chinese_PRC_CI_AS"),
                    Endorse_pname = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true, comment: "Endorsement print name", collation: "Chinese_PRC_CI_AS"),
                    Endorse_email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Endorsement Email", collation: "Chinese_PRC_CI_AS"),
                    Quotation = table.Column<int>(type: "int", nullable: true, comment: "Quotations from the suppliers 1 for have 0 for not"),
                    Approved_proposal = table.Column<int>(type: "int", nullable: true, comment: "Approved proposal (must be attached for project expenditure) 1 for have 0 for not"),
                    Other_info = table.Column<int>(type: "int", nullable: true, comment: "Other relavent information 1 for have 0 for not have."),
                    Status = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "status if in progress, ", collation: "Chinese_PRC_CI_AS"),
                    Last_modified_by = table.Column<int>(type: "int", nullable: true, comment: "Last_modified by account"),
                    Last_modified_time = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "When Last modified"),
                    Has_approved_proposal = table.Column<bool>(type: "bit", nullable: true, comment: "0 for not 1 for yes"),
                    Has_participants_list = table.Column<bool>(type: "bit", nullable: true, comment: "0 for not 1 for yes"),
                    Has_other_info = table.Column<bool>(type: "bit", nullable: true, comment: "0 for not 1 for yes"),
                    Approved_date = table.Column<DateTime>(type: "date", nullable: true, comment: "when approved")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PRAPropo__3214EC07F5E6D9C9_copy1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reimbursements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for Reimbursement")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ref_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Reference no", collation: "Chinese_PRC_CI_AS"),
                    Requester_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Requesters name", collation: "Chinese_PRC_CI_AS"),
                    Requester_email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Requester email", collation: "Chinese_PRC_CI_AS"),
                    Requester_tel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "requester tel or ext", collation: "Chinese_PRC_CI_AS"),
                    Contact_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Alternate Contact name", collation: "Chinese_PRC_CI_AS"),
                    Contact_email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Alternate Contact email", collation: "Chinese_PRC_CI_AS"),
                    Contact_tel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Alternate Contact tel.", collation: "Chinese_PRC_CI_AS"),
                    Proposal_ref_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Proposal or reference no", collation: "Chinese_PRC_CI_AS"),
                    Project_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Project number", collation: "Chinese_PRC_CI_AS"),
                    Project_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Project name", collation: "Chinese_PRC_CI_AS"),
                    Bank_letter_np = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Bank letter no", collation: "Chinese_PRC_CI_AS"),
                    Payment_date = table.Column<DateTime>(type: "date", nullable: true, comment: "Payment date"),
                    Cheque_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Cheque number", collation: "Chinese_PRC_CI_AS")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reimburs__3214EC0751390598", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for items")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Description of goods and/or services to be acquired", collation: "Chinese_PRC_CI_AS"),
                    Qty = table.Column<int>(type: "int", nullable: true, comment: "Quantity "),
                    Budget_line = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, collation: "Chinese_PRC_CI_AS"),
                    Reason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Reasons of making the acquistion", collation: "Chinese_PRC_CI_AS"),
                    Awardee = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "who gives the award", collation: "Chinese_PRC_CI_AS"),
                    Award_amount = table.Column<int>(type: "int", nullable: true, comment: "Award amount in MOP"),
                    Justification = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Justifications of the award", collation: "Chinese_PRC_CI_AS"),
                    Exemption = table.Column<int>(type: "int", nullable: true, comment: "1 for have Exemption 0 for not have"),
                    Justification_further = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "further justification under exemption", collation: "Chinese_PRC_CI_AS"),
                    Proposal_id = table.Column<int>(type: "int", nullable: true, comment: "Reference key to proposal")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Items__3214EC07A9F56075", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Items__Proposal___5AEE82B9",
                        column: x => x.Proposal_id,
                        principalTable: "PRAProposals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PRACompanyOperationExpenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for project expenditure")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proposal_ref_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Project or reference number", collation: "Chinese_PRC_CI_AS"),
                    Budget_line = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Budget line", collation: "Chinese_PRC_CI_AS"),
                    Total_amount_reserved = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Total amount to be reserved", collation: "Chinese_PRC_CI_AS"),
                    Proposal_id = table.Column<int>(type: "int", nullable: true, comment: "Reference key to PRAproposals")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProjectE__3214EC076594619C_copy1", x => x.Id);
                    table.ForeignKey(
                        name: "FK__PRACompan__Propo__5BE2A6F2",
                        column: x => x.Proposal_id,
                        principalTable: "PRAProposals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PRAProjectExpenditures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for project expenditure")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Project_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Project name", collation: "Chinese_PRC_CI_AS"),
                    Project_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Project number", collation: "Chinese_PRC_CI_AS"),
                    Proposal_ref_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Project or reference number", collation: "Chinese_PRC_CI_AS"),
                    Budget_line = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Budget line", collation: "Chinese_PRC_CI_AS"),
                    Total_amount_reserved = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Total amount to be reserved", collation: "Chinese_PRC_CI_AS"),
                    Proposal_id = table.Column<int>(type: "int", nullable: true, comment: "Reference key to PRAproposals")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProjectE__3214EC076594619C", x => x.Id);
                    table.ForeignKey(
                        name: "FK__PRAProjec__Propo__5DCAEF64",
                        column: x => x.Proposal_id,
                        principalTable: "PRAProposals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for items")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Purpose = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Purpose of goods and/or services to be acquired", collation: "Chinese_PRC_CI_AS"),
                    Date = table.Column<DateTime>(type: "date", nullable: true, comment: "date of meal"),
                    Estimated_no = table.Column<int>(type: "int", nullable: true),
                    Proposed_budget = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Proposed budget", collation: "Chinese_PRC_CI_AS"),
                    Awardee = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "who gives the award", collation: "Chinese_PRC_CI_AS"),
                    Award_amount = table.Column<int>(type: "int", nullable: true, comment: "Award amount in MOP"),
                    Justification = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Justifications of the award", collation: "Chinese_PRC_CI_AS"),
                    Exemption = table.Column<int>(type: "int", nullable: true, comment: "1 for have Exemption 0 for not have"),
                    Justification_further = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "further justification under exemption", collation: "Chinese_PRC_CI_AS"),
                    Proposal_id = table.Column<int>(type: "int", nullable: true, comment: "Reference key to Proposal")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Items__3214EC07A9F56075_copy1", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Meals__Proposal___5EBF139D",
                        column: x => x.Proposal_id,
                        principalTable: "PRAsubProposals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PRASCompanyOperationExpenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for project expenditure")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proposal_ref_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Project or reference number", collation: "Chinese_PRC_CI_AS"),
                    Budget_line = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Budget line", collation: "Chinese_PRC_CI_AS"),
                    Total_amount_reserved = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Total amount to be reserved", collation: "Chinese_PRC_CI_AS"),
                    Proposal_id = table.Column<int>(type: "int", nullable: true, comment: "Reference key to PRAproposals")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProjectE__3214EC076594619C_copy1_copy1", x => x.Id);
                    table.ForeignKey(
                        name: "FK__PRASCompa__Propo__60A75C0F",
                        column: x => x.Proposal_id,
                        principalTable: "PRAsubProposals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PRASProjectExpenditures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for project expenditure")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Project_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Project name", collation: "Chinese_PRC_CI_AS"),
                    Project_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Project number", collation: "Chinese_PRC_CI_AS"),
                    Proposal_ref_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Project or reference number", collation: "Chinese_PRC_CI_AS"),
                    Budget_line = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Budget line", collation: "Chinese_PRC_CI_AS"),
                    Total_amount_reserved = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Total amount to be reserved", collation: "Chinese_PRC_CI_AS"),
                    Proposal_id = table.Column<int>(type: "int", nullable: true, comment: "Reference key to PRAproposals")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProjectE__3214EC076594619C_copy2", x => x.Id);
                    table.ForeignKey(
                        name: "FK__PRASProje__Propo__619B8048",
                        column: x => x.Proposal_id,
                        principalTable: "PRAsubProposals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRateDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for Exchange Rate details")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Invoice_receipt_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Invoice or receipt number", collation: "Chinese_PRC_CI_AS"),
                    Invoice_receipt_date = table.Column<DateTime>(type: "date", nullable: true, comment: "Invoice or receipt date"),
                    Currency_amount = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Currency and amount", collation: "Chinese_PRC_CI_AS"),
                    Exchange_rate = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Exchange rate", collation: "Chinese_PRC_CI_AS"),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: true, comment: "Amount in MOP"),
                    Remarks = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Remark", collation: "Chinese_PRC_CI_AS"),
                    Reimbursement_id = table.Column<int>(type: "int", nullable: true, comment: "Reference key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Exchange__3214EC072F4CF62F", x => x.Id);
                    table.ForeignKey(
                        name: "FK__ExchangeR__Reimb__66603565",
                        column: x => x.Reimbursement_id,
                        principalTable: "Reimbursements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LocalAutoPayInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for Local payment info autopay")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Beneficiary_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Beneficiary Name", collation: "Chinese_PRC_CI_AS"),
                    Bank_account_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Bank account number", collation: "Chinese_PRC_CI_AS"),
                    Bank_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Bank Name", collation: "Chinese_PRC_CI_AS"),
                    Tax_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Tax ID", collation: "Chinese_PRC_CI_AS"),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Email address", collation: "Chinese_PRC_CI_AS"),
                    Contact_number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Contact's phone number", collation: "Chinese_PRC_CI_AS"),
                    Email_ref = table.Column<int>(type: "int", nullable: true, comment: "1 for refer to email 0 for not"),
                    Attachment_ref = table.Column<int>(type: "int", nullable: true, comment: "1 for refer to email 0 for not"),
                    Attachment_info = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Attachment info maybe number or sth", collation: "Chinese_PRC_CI_AS"),
                    Reimbursement_id = table.Column<int>(type: "int", nullable: true, comment: "Reference key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LocalAut__3214EC07F8DB133A", x => x.Id);
                    table.ForeignKey(
                        name: "FK__LocalAuto__Reimb__6477ECF3",
                        column: x => x.Reimbursement_id,
                        principalTable: "Reimbursements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LocalChequeCashiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for Local payment info autopay")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Beneficiary_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Beneficiary Name", collation: "Chinese_PRC_CI_AS"),
                    Tax_id = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Tax ID", collation: "Chinese_PRC_CI_AS"),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Email address", collation: "Chinese_PRC_CI_AS"),
                    Contact_number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Contact's phone number", collation: "Chinese_PRC_CI_AS"),
                    Email_ref = table.Column<int>(type: "int", nullable: true, comment: "1 for refer to email 0 for not"),
                    Attachment_ref = table.Column<int>(type: "int", nullable: true, comment: "1 for refer to attachment 0 for not"),
                    Attachment_info = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Attachment info", collation: "Chinese_PRC_CI_AS"),
                    Reimbursement_id = table.Column<int>(type: "int", nullable: true, comment: "Reference key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LocalAut__3214EC07F8DB133A_copy1", x => x.Id);
                    table.ForeignKey(
                        name: "FK__LocalCheq__Reimb__656C112C",
                        column: x => x.Reimbursement_id,
                        principalTable: "Reimbursements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NonLocalBankDrafts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key to Nonlocal Band draft")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Beneficiary_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Beneficiary Name", collation: "Chinese_PRC_CI_AS"),
                    Designated_currency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Designated Currency", collation: "Chinese_PRC_CI_AS"),
                    Mailing_address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Mailing address", collation: "Chinese_PRC_CI_AS"),
                    Id_passport_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Id or passport number", collation: "Chinese_PRC_CI_AS"),
                    Beneficiary_bank_city = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "City of beneficiary bank", collation: "Chinese_PRC_CI_AS"),
                    Email_address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Email address", collation: "Chinese_PRC_CI_AS"),
                    Contact_number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Contact number", collation: "Chinese_PRC_CI_AS"),
                    Email_ref = table.Column<int>(type: "int", nullable: true, comment: "1 for ref to email"),
                    Attachment_ref = table.Column<int>(type: "int", nullable: true, comment: "Attachment ref 1 for have"),
                    Attachment_info = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Attachemtn info", collation: "Chinese_PRC_CI_AS"),
                    Reimbursement_id = table.Column<int>(type: "int", nullable: true, comment: "Reference key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NonLocal__3214EC07F72877F0", x => x.Id);
                    table.ForeignKey(
                        name: "FK__NonLocalB__Reimb__6383C8BA",
                        column: x => x.Reimbursement_id,
                        principalTable: "Reimbursements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NonLocalTelegraphicTransfers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for NonLocalTelegraphicTransferInfos")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Beneficiary_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Beneficiary Name", collation: "Chinese_PRC_CI_AS"),
                    Bank_account_number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Bank account number", collation: "Chinese_PRC_CI_AS"),
                    Bank_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Bank name", collation: "Chinese_PRC_CI_AS"),
                    Designated_currency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Designated Currency", collation: "Chinese_PRC_CI_AS"),
                    Bank_address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Bank address or Branch District", collation: "Chinese_PRC_CI_AS"),
                    ID_passport_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "ID or Passport number", collation: "Chinese_PRC_CI_AS"),
                    Swift_code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Swift Code 8 to 11 digits", collation: "Chinese_PRC_CI_AS"),
                    ABA_routing_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "APA routing no for USA", collation: "Chinese_PRC_CI_AS"),
                    IBAN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "IBAN for Europe", collation: "Chinese_PRC_CI_AS"),
                    BSB_no = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "BSB number for Australia", collation: "Chinese_PRC_CI_AS"),
                    Beneficiary_home_address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Beneficiary home address for Canada", collation: "Chinese_PRC_CI_AS"),
                    Email_address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Contact email address", collation: "Chinese_PRC_CI_AS"),
                    Contact_number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Contact number", collation: "Chinese_PRC_CI_AS"),
                    Email_ref = table.Column<int>(type: "int", nullable: true, comment: "1 for ref to email"),
                    Attachment_ref = table.Column<int>(type: "int", nullable: true, comment: "1 for ref to attachment"),
                    Attachment_info = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Attachment info", collation: "Chinese_PRC_CI_AS"),
                    Reimbursement_id = table.Column<int>(type: "int", nullable: true, comment: "Reference key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NonLocal__3214EC07D0617736", x => x.Id);
                    table.ForeignKey(
                        name: "FK__NonLocalT__Reimb__6754599E",
                        column: x => x.Reimbursement_id,
                        principalTable: "Reimbursements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for Reimbursement details")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Item name", collation: "Chinese_PRC_CI_AS"),
                    Documents_no = table.Column<int>(type: "int", nullable: true, comment: "number of documents attached"),
                    Currency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Currency type", collation: "Chinese_PRC_CI_AS"),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: true, comment: "Amount"),
                    Payee_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Payee's name", collation: "Chinese_PRC_CI_AS"),
                    Bank_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Bank name", collation: "Chinese_PRC_CI_AS"),
                    Bank_account_no = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true, comment: "Bank account number", collation: "Chinese_PRC_CI_AS"),
                    Reimbursement_id = table.Column<int>(type: "int", nullable: true, comment: "Rerference key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Payment___3214EC074277448B", x => x.Id);
                    table.ForeignKey(
                        name: "FK__PaymentDe__Reimb__68487DD7",
                        column: x => x.Reimbursement_id,
                        principalTable: "Reimbursements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReimbursementTotals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Id for reimbursement total")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Currency = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, comment: "Currency type of reimbursement total", collation: "Chinese_PRC_CI_AS"),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: true, comment: "Reimbursement Amount "),
                    Reimbursement_id = table.Column<int>(type: "int", nullable: true, comment: "Reference key to reimbursement")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reimburs__3214EC07214DE23E", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Reimburse__Reimb__628FA481",
                        column: x => x.Reimbursement_id,
                        principalTable: "Reimbursements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemQuotations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for quotations of proposals items")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Company name of quotation", collation: "Chinese_PRC_CI_AS"),
                    Amount = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true, comment: "Amount in MOP", collation: "Chinese_PRC_CI_AS"),
                    Item_id = table.Column<int>(type: "int", nullable: true, comment: "Reference key to item")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Quotatio__3214EC07D7D46E53", x => x.Id);
                    table.ForeignKey(
                        name: "FK__ItemQuota__Item___5CD6CB2B",
                        column: x => x.Item_id,
                        principalTable: "Items",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MealQuotations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Primary key for quotations of proposals items")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, comment: "Company name of quotation", collation: "Chinese_PRC_CI_AS"),
                    Amount = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true, comment: "Amount in MOP", collation: "Chinese_PRC_CI_AS"),
                    Meal_id = table.Column<int>(type: "int", nullable: true, comment: "Reference key to item")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Quotatio__3214EC07D7D46E53_copy1", x => x.Id);
                    table.ForeignKey(
                        name: "FK__MealQuota__Meal___5FB337D6",
                        column: x => x.Meal_id,
                        principalTable: "Meals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ExchangeRateDetails_Reimbursement_id",
                table: "ExchangeRateDetails",
                column: "Reimbursement_id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemQuotations_Item_id",
                table: "ItemQuotations",
                column: "Item_id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Proposal_id",
                table: "Items",
                column: "Proposal_id");

            migrationBuilder.CreateIndex(
                name: "IX_LocalAutoPayInfos_Reimbursement_id",
                table: "LocalAutoPayInfos",
                column: "Reimbursement_id");

            migrationBuilder.CreateIndex(
                name: "IX_LocalChequeCashiers_Reimbursement_id",
                table: "LocalChequeCashiers",
                column: "Reimbursement_id");

            migrationBuilder.CreateIndex(
                name: "IX_MealQuotations_Meal_id",
                table: "MealQuotations",
                column: "Meal_id");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_Proposal_id",
                table: "Meals",
                column: "Proposal_id");

            migrationBuilder.CreateIndex(
                name: "IX_NonLocalBankDrafts_Reimbursement_id",
                table: "NonLocalBankDrafts",
                column: "Reimbursement_id");

            migrationBuilder.CreateIndex(
                name: "IX_NonLocalTelegraphicTransfers_Reimbursement_id",
                table: "NonLocalTelegraphicTransfers",
                column: "Reimbursement_id");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_Reimbursement_id",
                table: "PaymentDetails",
                column: "Reimbursement_id");

            migrationBuilder.CreateIndex(
                name: "IX_PRACompanyOperationExpenses_Proposal_id",
                table: "PRACompanyOperationExpenses",
                column: "Proposal_id");

            migrationBuilder.CreateIndex(
                name: "IX_PRAProjectExpenditures_Proposal_id",
                table: "PRAProjectExpenditures",
                column: "Proposal_id");

            migrationBuilder.CreateIndex(
                name: "IX_PRASCompanyOperationExpenses_Proposal_id",
                table: "PRASCompanyOperationExpenses",
                column: "Proposal_id");

            migrationBuilder.CreateIndex(
                name: "IX_PRASProjectExpenditures_Proposal_id",
                table: "PRASProjectExpenditures",
                column: "Proposal_id");

            migrationBuilder.CreateIndex(
                name: "IX_ReimbursementTotals_Reimbursement_id",
                table: "ReimbursementTotals",
                column: "Reimbursement_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EventRequests");

            migrationBuilder.DropTable(
                name: "ExchangeRateDetails");

            migrationBuilder.DropTable(
                name: "ItemQuotations");

            migrationBuilder.DropTable(
                name: "LocalAutoPayInfos");

            migrationBuilder.DropTable(
                name: "LocalChequeCashiers");

            migrationBuilder.DropTable(
                name: "MealQuotations");

            migrationBuilder.DropTable(
                name: "NonLocalBankDrafts");

            migrationBuilder.DropTable(
                name: "NonLocalTelegraphicTransfers");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "PRACompanyOperationExpenses");

            migrationBuilder.DropTable(
                name: "PRAProjectExpenditures");

            migrationBuilder.DropTable(
                name: "PRASCompanyOperationExpenses");

            migrationBuilder.DropTable(
                name: "PRASProjectExpenditures");

            migrationBuilder.DropTable(
                name: "ReimbursementTotals");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Reimbursements");

            migrationBuilder.DropTable(
                name: "PRAProposals");

            migrationBuilder.DropTable(
                name: "PRAsubProposals");
        }
    }
}
