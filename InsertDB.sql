/*SQL SCRIPT FOR FULLFILL DB*/

--AFTER INSERT SET IDENTITY_INSERT TO OFF


--DEPARTMENTS
--SET IDENTITY_INSERT Departments ON;
insert into Departments (id, Name, Location)
VALUES (1, 'Hr', 'Warsaw');
insert into Departments (id, Name, Location)
VALUES (2, 'Developer', 'Warsaw');
insert into Departments (id, Name, Location)
VALUES (3, 'QA', 'Warsaw');
insert into Departments (id, Name, Location)
VALUES (4, 'QA', 'Krakow');
insert into Departments (id, Name, Location)
VALUES (5, 'Developer', 'Krakow');

SELECT * FROM Departments;


--MODULES
--SET IDENTITY_INSERT Modules ON;
insert into Modules (id , Name , Desctription , Type)
VALUES (1, 'Private and Security','Our Security and Privacy module is designed to empower employees with the knowledge and skills necessary to safeguard sensitive information and maintain a secure working environment. This module covers essential topics such as data protection practices, secure handling of confidential information, recognizing and responding to cybersecurity threats, and understanding company policies regarding privacy and security. ', 'Mandatory');
insert into Modules (id , Name , Desctription , Type)
VALUES (2, 'Project structure','This module is created for common understanding of the project structure, its also includes uml diagrams and AWS structure.',  'Mandatory');
insert into Modules (id , Name , Desctription , Type)
VALUES (3, 'Project Goals', 'Project Goals module is created for deeper knowledge of goals and values of this project.', 'Optional');

SELECT * from Modules;


--PROJETS
-- SET IDENTITY_INSERT Projects ON;
insert into Projects (id, Name, GeneralInfo, Customer) 
VALUES (1, 'LSEG MDST', 'LSEG is a leading global financial markets infrastructure and data provider. We play a vital social and economic role in the world�s financial system. This project is created to develop and support cloud architecture in AWS', 'LSEG');
insert into Projects (id, Name, GeneralInfo, Customer) 
VALUES (2, 'LSEG DB', 'LSEG is a leading global financial markets infrastructure and data provider. We play a vital social and economic role in the world�s financial system. This project is associated with data transfer and databese of applications, in company.', 'LSEG');
insert into Projects (id, Name, GeneralInfo, Customer) 
VALUES (3, 'UBS G', 'UBS is a global firm providing financial services in over 50 countries. Main goal of yhe project is to maintain Android applications on Java 11 and support JUnit testing as well as H2 database', 'UBS');
insert into Projects (id, Name, GeneralInfo, Customer) 
VALUES (4, 'Netflix QA&Testing', 'This project is held to test by QA developers all features introduced to the application , maintain CI/CD pipelines, work with gitlab as well as with Jenkins .', 'Netflix');
insert into Projects(id, Name, GeneralInfo, Customer) 
VALUES (5, 'Support Line 1', 'This is project oppened for Google , where you will take part as support team member.  ', 'Google');

SELECT * from Projects;


--EVENTS
--SET IDENTITY_INSERT Events ON;
insert into Events (Id, Name, Description, Type, HeldDate)
VALUES (1, ' CS GO Game Tournament', 'Event where players compete in teams to showcase their gaming skills and compete for prizes. To organize a successful CS:GO game tournament in a company setting, you could:

1. Decide on the format: Will it be a team tournament or an individual tournament? Will there be a group stage and then knockout rounds? Will the matches be played online or in person?

2. Determine the rules: Establish the rules for the game and how the tournament will be organized. This might include the rules for team formation, moving to the next round, and how the winner will be determined.

3. Choose the teams: Participants can be employees or recruited from the community. If it is a team tournament, select team captains and hold a draft to decide the teams.

4. Set up the gaming environment: Make sure you have the necessary equipment such as gaming systems, controllers, and headsets. You''ll also need to set up the game servers and accounts for all participants.

5. Create a schedule for matches: Participants should know in advance when they''ll be playing their matches so they can practice and prepare. You can use software like Challonge or Toornament to create a tournament bracket and schedule the matches.

6. Determine the prize money: Decide on the amount available for prize money and how it will be distributed. Ensure the prize money is fair and distributed according to the rules.

7. Promote the tournament: Spread the word about the tournament through your company''s communication channels and social media.

8. Hire a referee if necessary: You may want to hire a referee to help ensure fair play and adherence to the rules.

Remember, the goal of a CS:GO game tournament is to have fun and encourage teamwork and friendly competition. The tournament can also be a great opportunity to connect with colleagues and build relationships.', 'Optional', '2024-02-27');
insert into Events (Id, Name, Description, Type, HeldDate)
VALUES (2, 'Team Building', 'A team-building event for a C# .NET Web API project is a great way to bring together a group of developers, testers, project managers, and other stakeholders to work, learn, and grow together.',  'Mandatory', '2024-04-11 12:00');
insert into Events (Id, Name, Description, Type, HeldDate)
VALUES (3, 'Java Certification ','Here are some potential elements that could be included in a Java certification event:

1. Java training sessions: Attendees could participate in expert-led training sessions that are specifically geared towards the topics covered on Java certification exams. These sessions could be hands-on and include exercises that allow attendees to practice coding.

2. Exam preparation workshops: Workshops could be dedicated to helping attendees prepare for Java certification exams. These workshops could include tips and tricks for taking the exams, guidance on study resources, and strategies for passing the exam.

3. Practice exams: Providing attendees with practice exams that mimic the real certification exams could be an effective way to help them prepare. Practice exams could be timed, and they could include questions that are similar to those that appear on the actual certification exams.

4. Demonstrations: Attendees could participate in live demonstrations of key Java concepts and techniques. These demonstrations could be led by experts, and they could include explanations of why certain coding techniques work the way they do.

5. Networking opportunities: Networking opportunities could be built into the Java certification event to give attendees a chance to meet others who are also studying for Java certification exams. These opportunities could include cocktail hours, dinners, or even team-building exercises.

Overall, a Java certification event could be an effective way for attendees to develop their Java programming skills and prepare for certification exams. With expert-led training, practice exams, and networking opportunities, attendees could leave the event feeling confident and ready to pass their Java certification exams.', 'Mandatory',  '2024-03-01 15:00:00');

SELECT * from Events;


--QUESTIONS
--SET IDENTITY_INSERT Questions ON;
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (1, 'Is it good idea to enable MFA?' , 'Yes', 1);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (2, 'Is it generally considered safe to use Starbucks Public Wi-Fi network for performing an online banking operation?' , 'No', 1);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (3, 'Is it considered a good security practice to leave your machine unlocked when you leave your desk?' , 'No', 1);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (4, 'Are employees allowed to share their login credentials with colleagues?' , 'No', 1);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (5, 'Should sensitive company information be discussed in public areas where others may overhear?' , 'No', 1);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (6, 'Is it safe to download and install software from unverified sources on company devices?' , 'No', 1);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (7, 'Should employees report any suspicious emails or messages received on their work email accounts?' , 'Yes', 1);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (8, 'Can employees access confidential company documents from personal devices without proper authorization?' , 'No', 1);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (9, 'Should employees be trained on recognizing social engineering techniques used by attackers to gain unauthorized access to company systems?' , 'Yes', 1);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (10, 'Is it safe to reuse passwords across multiple accounts, including personal and work-related ones?' , 'No', 1);

insert into Questions(Id, Description, Answer, ModuleId)
VALUES (11, ' Is it acceptable to modify the project structure without consulting team members or project leads?' , 'No', 2);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (12, 'Should project folders and files be organized logically and consistently to ensure ease of navigation and maintenance?' , 'Yes', 2);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (13, 'Is it recommended to include detailed documentation outlining the project structure and file organization?' , 'Yes', 2);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (14, 'Should project structure evolve dynamically based on changing project requirements and scope?' , 'Yes', 2);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (15, 'Is it advisable to include unnecessary or redundant files and folders in the project structure?' , 'No', 2);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (16, 'Should project structure adhere to industry-standard conventions and best practices?' , 'Yes', 2);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (17, 'Is it appropriate to have multiple versions of the same file scattered across different folders within the project structure?' , 'No', 2);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (18, 'Should developers regularly review and refactor the project structure to maintain its integrity and efficiency?' , 'Yes', 2);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (19, 'Is it acceptable to have inconsistent naming conventions for files and folders within the project structure?' , 'No', 2);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (20, 'Should project structure support easy integration with version control systems such as Git?' , 'Yes', 2);

insert into Questions(Id, Description, Answer, ModuleId)
VALUES (21, 'Are project goals defined and communicated clearly to all team members?' , 'Yes', 3);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (22, 'Should project goals align with the overall objectives and vision of the organization?' , 'Yes', 3);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (23, 'Is it acceptable to have vague or ambiguous project goals that can be interpreted differently by team members?' , 'No', 3);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (24, 'Should project goals be realistic and achievable within the given constraints (time, budget, resources)?' , 'Yes', 3);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (25, 'Is it advisable to periodically review and revise project goals based on changing circumstances or stakeholder feedback?' , 'Yes', 3);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (26, 'Should project goals prioritize delivering value to stakeholders and meeting customer needs?' , 'Yes', 3);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (27, ' Is it appropriate to set project goals that are overly broad or generic, making it difficult to measure progress?' , 'No', 3);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (28, 'Should project goals be documented and tracked throughout the project lifecycle?' , 'Yes', 3);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (29, 'Is it acceptable to have conflicting or contradictory project goals that may lead to confusion or inefficiency?' , 'No', 3);
insert into Questions(Id, Description, Answer, ModuleId)
VALUES (30, 'Should project goals be SMART (Specific, Measurable, Achievable, Relevant, Time-bound) to ensure clarity and focus?' , 'Yes', 3);

SELECT * from Questions;


--USERS
-- REGULAR USER ROLE , PASSWORD: User2123
Insert into AspNetUsers(Id, Surname, Sex, StatusOfEducation, DateOfBirth, HiringDate, Salary, DepartmentId, ProjectId, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount)
VALUES('user2', 'Dragicevic', 'Male', 'Master degree', '1999-03-28 11:00', '2023-11-12 09:00', 7500, 1, 1, 'user2@gmail.com', 'USER2@GMAIL.COM', 'user2@gmail.com', 'USER2@GMAIL.COM', 1, 'AQAAAAIAAYagAAAAENtBFwbq+uzMvrwO2Iv1SPu6CN72t1/MFMRbGddCCNppGK3+OVQxyOzxHLKvsGLVQA==','ESOAQENU336GAFOG3SQAKB6PUJ3E5UKZ', '560809f9-e678-4d9c-bc1a-74e01577549f', '+4887687676' , 1 ,0, null, 1, 0);
--MANAGER ROLE, PASSWORD: Manager123
Insert into AspNetUsers(Id, Surname, Sex, StatusOfEducation, DateOfBirth, HiringDate, Salary, DepartmentId, ProjectId, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount)
VALUES('manager1', 'Baranchykava', 'Male', 'School', '2002-04-11 10:00', '2021-01-12 09:00', 11500, 3, 2, 's20897@pjwstk.edu.pl', 'S20897@PJWSTK.EDU.PL', 's20897@pjwstk.edu.pl', '20897@PJWSTK.EDU.PL', 1, 'AQAAAAIAAYagAAAAEIEI4aVc9lUjwPpYl/GeMvZwEFqiWKaM3QgqjMXzrHQyVGsDPyprac8ndLPj4yiUYA==','YWGQQA6NUCVUIQT3NWY7Z5DHOO5GTGTF', '852332ff-3610-40b9-916c-2d290e8df397', '+48666555444' , 1 ,0, null, 1, 0);
--ADMIN ROLE, PASSWORD: Admin123
Insert into AspNetUsers(Id, Surname, Sex, StatusOfEducation, DateOfBirth, HiringDate, Salary, DepartmentId, ProjectId, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount)
VALUES('admin1', 'Markina', 'Female', 'Bachelor', '1967-08-22 10:00', '2008-11-22 09:00', 21500, 4, 3, 'Admin@omcany.com', 'ADMIN@OMCANY.COM', 'Admin@omcany.com', 'ADMIN@OMCANY.COM', 0, 'AQAAAAIAAYagAAAAEOqhbm3u6FE4WjKYyVHnjps/kTg2gLpLCqmmZ2a56NJUruGBwewziDNkDMcBaRUSVg==','5EIHSCL6ADFSH3DLMGHYRH56IBOMLIJG', '0fe52e4d-0ac6-45c9-aac8-43fdb492741d', '+48543327888' , 0 ,0, null, 1, 0);

select * from AspNetUsers;


--ROLES
Insert into AspNetRoles(id, name, NormalizedName, ConcurrencyStamp)
VALUES (1, 'Admin', 'ADMIN', null);
Insert into AspNetRoles(id, name, NormalizedName, ConcurrencyStamp)
VALUES (2, 'Manager', 'MANAGER', null);
Insert into AspNetRoles(id, name, NormalizedName, ConcurrencyStamp)
VALUES (3, 'User', 'USER', null);

select * from AspNetRoles;


--USERROLES
Insert into AspNetUserRoles(UserId, RoleId)
VALUES ('admin1', 1);
Insert into AspNetUserRoles(UserId, RoleId)
VALUES ('manager1', 2);
Insert into AspNetUserRoles(UserId, RoleId)
VALUES ('user2', 3);

select * from AspNetUserRoles;


--MODULEUSERS
insert into ModuleUser(ModulesId,UsersId, Completed)
VALUES (1, 'admin1', 1);
insert into ModuleUser(ModulesId,UsersId, Completed)
VALUES (1, 'manager1', 1);
insert into ModuleUser(ModulesId,UsersId, Completed)
VALUES (1, 'user2', 0);
insert into ModuleUser(ModulesId,UsersId, Completed)
VALUES (2, 'admin1', 1);
insert into ModuleUser(ModulesId,UsersId, Completed)
VALUES (2, 'manager1', 1);
insert into ModuleUser(ModulesId,UsersId, Completed)
VALUES (2, 'user2', 1);
insert into ModuleUser(ModulesId,UsersId, Completed)
VALUES (3, 'manager1', 0);
insert into ModuleUser(ModulesId,UsersId, Completed)
VALUES (3, 'user2', 0);

select * from ModuleUser;














