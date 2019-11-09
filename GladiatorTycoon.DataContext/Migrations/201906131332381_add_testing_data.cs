namespace GladiatorTycoon.DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_testing_data : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO `gladiator_tycoon`.`races` (`Name`, `AvailableGenders`, `PositiveHabitats`, `NegativeHabitats`) VALUES ('Mennesker', 0, 'Wasteland,Frozen', 'Jungle,Desert');
INSERT INTO `gladiator_tycoon`.`races` (`Name`, `AvailableGenders`, `PositiveHabitats`, `NegativeHabitats`) VALUES ('Hito', 0, 'Temperate,Mountain', 'Wasteland,Underground');
INSERT INTO `gladiator_tycoon`.`races` (`Name`, `AvailableGenders`, `PositiveHabitats`, `NegativeHabitats`) VALUES ('Ashkhas', 0, 'Desert,Savannah', 'Frozen,Mountain');
INSERT INTO `gladiator_tycoon`.`races` (`Name`, `AvailableGenders`, `PositiveHabitats`, `NegativeHabitats`) VALUES ('Anthropos', 0, 'Temperate,Savannah,Forest', 'Wasteland,Underground,Frozen');

INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Head', 'Mennesker Head', 0, 0, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Torso', 'Mennesker Torso', 1, 0, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Arm', 'Mennesker Arm', 2, 7, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Leg', 'Mennesker Leg', 3, 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));

INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Head', 'Hito Head', 0, 0, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Torso', 'Hito Torso', 1, 0, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Arm', 'Hito Arm', 2, 7, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Leg', 'Hito Leg', 3, 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));

INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Head', 'Ashkhas Head', 0, 0, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Torso', 'Ashkhas Torso', 1, 0, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Arm', 'Ashkhas Arm', 2, 7, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Leg', 'Ashkhas Leg', 3, 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));

INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Head', 'Anthropos Head', 0, 0, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Torso', 'Anthropos Torso', 1, 0, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Arm', 'Anthropos Arm', 2, 7, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`racebodyparts` (`Name`, `DevName`, `BodyPartType`, `AvailableActions`, `IsVital`, `RaceEntity_Id`)
VALUES ('Leg', 'Anthropos Leg', 3, 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));


INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Om', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Eric', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Loki', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Den', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Harold', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));

INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Dahlia', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Erica', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Tori', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Freya', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Elin', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));

INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Asgeir', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Brynjolf', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Gunnulf', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Hastein', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Njall', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Mennesker'));


INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Haruto', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Riku', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Kaito', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Yuuto', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Itsuki', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));

INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Hana', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Himari', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Akari', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Yui', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Niko', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));

INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Takahashi', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Watanabe', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Yamamoto', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Saito', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Kobayashi', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Hito'));


INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Achilles', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Kristo', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Orien', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Sirius', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Vasilios', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));

INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Phoebe', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Rhea', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Penelope', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Helen', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Calliope', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));

INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Adamos', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Diamantopoulos', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Kyriakou', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Manikas', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Petrakis', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Anthropos'));


INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Abanoub', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Eshaq', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Khnurn', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Neferu', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Thethi', 1, 1, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));

INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Berenike', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Chione', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Cliupatra', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Isis', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Rana', 1, 2, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));

INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Abasi', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Jafari', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Mukhwana', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Shakir', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));
INSERT INTO `gladiator_tycoon`.`personnames` (`Text`, `IsFirstName`, `Gender`, `RaceEntity_Id`)
VALUES ('Zuberi', 0, 0, (SELECT `Id` FROM `gladiator_tycoon`.`races` WHERE `Name`='Ashkhas'));

INSERT INTO `gladiator_tycoon`.`cities` (`Name`, `Habitat`)
VALUES ('Hellscape', 0);
INSERT INTO `gladiator_tycoon`.`cities` (`Name`, `Habitat`)
VALUES ('Asgar', 1);
INSERT INTO `gladiator_tycoon`.`cities` (`Name`, `Habitat`)
VALUES ('Thighkohm', 2);
INSERT INTO `gladiator_tycoon`.`cities` (`Name`, `Habitat`)
VALUES ('Terraced Enclave', 3);
INSERT INTO `gladiator_tycoon`.`cities` (`Name`, `Habitat`)
VALUES ('La Forêt des Hirondelles', 4);
INSERT INTO `gladiator_tycoon`.`cities` (`Name`, `Habitat`)
VALUES ('Serenghast', 5);
INSERT INTO `gladiator_tycoon`.`cities` (`Name`, `Habitat`)
VALUES ('Wailing Thicket', 6);
INSERT INTO `gladiator_tycoon`.`cities` (`Name`, `Habitat`)
VALUES ('Burning Desert', 7);
INSERT INTO `gladiator_tycoon`.`cities` (`Name`, `Habitat`)
VALUES ('Dread Labyrinth', 8);
");
        }
        
        public override void Down()
        {
        }
    }
}
