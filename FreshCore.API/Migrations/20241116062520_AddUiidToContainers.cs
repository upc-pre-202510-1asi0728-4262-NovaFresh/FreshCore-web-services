using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FreshCore.API.Migrations
{
    /// <inheritdoc />
    public partial class AddUiidToContainers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BusinessName = table.Column<string>(type: "text", nullable: false),
                    BusinessId = table.Column<string>(type: "text", nullable: false),
                    RepresentativeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccountId = table.Column<int>(type: "integer", nullable: false),
                    TierId = table.Column<int>(type: "integer", nullable: false),
                    PaymentDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SubscriptionStatusId = table.Column<int>(type: "integer", nullable: false),
                    LastPaidPeriod = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    MaxTemperatureThreshold = table.Column<short>(type: "smallint", nullable: false),
                    MinTemperatureThreshold = table.Column<short>(type: "smallint", nullable: false),
                    MaxHumidityThreshold = table.Column<float>(type: "real", nullable: false),
                    MinHumidityThreshold = table.Column<float>(type: "real", nullable: false),
                    MinOxygenThreshold = table.Column<int>(type: "integer", nullable: true),
                    MaxOxygenThreshold = table.Column<int>(type: "integer", nullable: true),
                    MinCarbonDioxideThreshold = table.Column<int>(type: "integer", nullable: true),
                    MaxCarbonDioxideThreshold = table.Column<int>(type: "integer", nullable: true),
                    MinSulfurDioxideThreshold = table.Column<int>(type: "integer", nullable: true),
                    MaxSulfurDioxideThreshold = table.Column<int>(type: "integer", nullable: true),
                    MinEthyleneThreshold = table.Column<int>(type: "integer", nullable: true),
                    MaxEthyleneThreshold = table.Column<int>(type: "integer", nullable: true),
                    MinAmmoniaThreshold = table.Column<int>(type: "integer", nullable: true),
                    MaxAmmoniaThreshold = table.Column<int>(type: "integer", nullable: true),
                    Category = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Latitude = table.Column<double>(type: "double precision", nullable: true),
                    Longitude = table.Column<double>(type: "double precision", nullable: true),
                    PlusCode = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: false),
                    FacilityType = table.Column<string>(type: "text", nullable: false),
                    LocationId = table.Column<int>(type: "integer", nullable: false),
                    ContainerCount = table.Column<int>(type: "integer", nullable: false),
                    ProfileCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Containers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uiid = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: false),
                    GroupId = table.Column<int>(type: "integer", nullable: false),
                    ContainerSizeId = table.Column<int>(type: "integer", nullable: false),
                    Temperature = table.Column<double>(type: "double precision", nullable: true),
                    Humidity = table.Column<double>(type: "double precision", nullable: true),
                    Oxygen = table.Column<double>(type: "double precision", nullable: true),
                    Dioxide = table.Column<double>(type: "double precision", nullable: true),
                    Ethylene = table.Column<double>(type: "double precision", nullable: true),
                    Ammonia = table.Column<double>(type: "double precision", nullable: true),
                    SulfurDioxide = table.Column<double>(type: "double precision", nullable: true),
                    ContainerConditions_MaxTemperature = table.Column<double>(type: "double precision", nullable: true),
                    ContainerConditions_MinTemperature = table.Column<double>(type: "double precision", nullable: true),
                    ContainerConditions_MaxHumidity = table.Column<double>(type: "double precision", nullable: true),
                    ContainerConditions_MinHumidity = table.Column<double>(type: "double precision", nullable: true),
                    ContainerConditions_OxygenMin = table.Column<double>(type: "double precision", nullable: true),
                    ContainerConditions_OxygenMax = table.Column<double>(type: "double precision", nullable: true),
                    ContainerConditions_DioxideMin = table.Column<double>(type: "double precision", nullable: true),
                    ContainerConditions_DioxideMax = table.Column<double>(type: "double precision", nullable: true),
                    ContainerConditions_EthyleneMin = table.Column<double>(type: "double precision", nullable: true),
                    ContainerConditions_EthyleneMax = table.Column<double>(type: "double precision", nullable: true),
                    ContainerConditions_AmmoniaMin = table.Column<double>(type: "double precision", nullable: true),
                    ContainerConditions_AmmoniaMax = table.Column<double>(type: "double precision", nullable: true),
                    ContainerConditions_SulfurDioxideMin = table.Column<double>(type: "double precision", nullable: true),
                    ContainerConditions_SulfurDioxideMax = table.Column<double>(type: "double precision", nullable: true),
                    LastKnownHealthStatus = table.Column<int>(type: "integer", nullable: false),
                    LastKnownHealthStatusReport = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastKnownContainerStatus = table.Column<int>(type: "integer", nullable: false),
                    LastKnownContainerStatusReport = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastSync = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Containers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Containers_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    GroupId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProfilePrivileges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProfileId = table.Column<int>(type: "integer", nullable: false),
                    Privilege = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilePrivileges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfilePrivileges_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Containers_GroupId",
                table: "Containers",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_LocationId",
                table: "Groups",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfilePrivileges_ProfileId",
                table: "ProfilePrivileges",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_GroupId",
                table: "Profiles",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Containers");

            migrationBuilder.DropTable(
                name: "ProfilePrivileges");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "locations");
        }
    }
}
