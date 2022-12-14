CREATE TABLE book(
    id SERIAL PRIMARY KEY,
	title VARCHAR(100) NOT NULL,
	page_number INTEGER NOT NULL,
	author_id INTEGER REFERENCES author(id)
);
insert into book (title, page_number, author_id) values ('Help Desk Technician', 289, 8);
insert into book (title, page_number, author_id) values ('Structural Analysis Engineer', 383, 34);
insert into book (title, page_number, author_id) values ('Executive Secretary', 389, 20);
insert into book (title, page_number, author_id) values ('Marketing Manager', 205, 21);
insert into book (title, page_number, author_id) values ('Structural Analysis Engineer', 371, 25);
insert into book (title, page_number, author_id) values ('Legal Assistant', 48, 22);
insert into book (title, page_number, author_id) values ('Internal Auditor', 105, 17);
insert into book (title, page_number, author_id) values ('Help Desk Technician', 247, 24);
insert into book (title, page_number, author_id) values ('Marketing Manager', 253, 17);
insert into book (title, page_number, author_id) values ('Editor', 248, 16);
insert into book (title, page_number, author_id) values ('Dental Hygienist', 374, 36);
insert into book (title, page_number, author_id) values ('Analyst Programmer', 92, 19);
insert into book (title, page_number, author_id) values ('Pharmacist', 54, 34);
insert into book (title, page_number, author_id) values ('Biostatistician I', 150, 26);
insert into book (title, page_number, author_id) values ('Speech Pathologist', 240, 26);
insert into book (title, page_number, author_id) values ('Compensation Analyst', 46, 28);
insert into book (title, page_number, author_id) values ('Occupational Therapist', 148, 39);
insert into book (title, page_number, author_id) values ('Analog Circuit Design manager', 66, 4);
insert into book (title, page_number, author_id) values ('Financial Advisor', 126, 5);
insert into book (title, page_number, author_id) values ('Assistant Media Planner', 173, 17);
insert into book (title, page_number, author_id) values ('Project Manager', 284, 12);
insert into book (title, page_number, author_id) values ('Web Developer II', 224, 1);
insert into book (title, page_number, author_id) values ('Professor', 369, 27);
insert into book (title, page_number, author_id) values ('Environmental Specialist', 330, 17);
insert into book (title, page_number, author_id) values ('Legal Assistant', 368, 33);
insert into book (title, page_number, author_id) values ('Recruiting Manager', 151, 39);
insert into book (title, page_number, author_id) values ('Software Engineer IV', 222, 17);
insert into book (title, page_number, author_id) values ('Director of Sales', 198, 15);
insert into book (title, page_number, author_id) values ('Internal Auditor', 379, 11);
insert into book (title, page_number, author_id) values ('Help Desk Operator', 219, 28);
insert into book (title, page_number, author_id) values ('Biostatistician III', 160, 36);
insert into book (title, page_number, author_id) values ('Biostatistician I', 188, 18);
insert into book (title, page_number, author_id) values ('Cost Accountant', 150, 20);
insert into book (title, page_number, author_id) values ('Social Worker', 119, 8);
insert into book (title, page_number, author_id) values ('Media Manager III', 358, 25);
insert into book (title, page_number, author_id) values ('Senior Quality Engineer', 262, 4);
insert into book (title, page_number, author_id) values ('Structural Analysis Engineer', 69, 13);
insert into book (title, page_number, author_id) values ('Sales Representative', 199, 12);
insert into book (title, page_number, author_id) values ('Human Resources Manager', 64, 2);
insert into book (title, page_number, author_id) values ('VP Sales', 99, 26);
insert into book (title, page_number, author_id) values ('Teacher', 144, 22);
insert into book (title, page_number, author_id) values ('Chemical Engineer', 285, 28);
insert into book (title, page_number, author_id) values ('Social Worker', 295, 19);
insert into book (title, page_number, author_id) values ('Structural Analysis Engineer', 194, 20);
insert into book (title, page_number, author_id) values ('Electrical Engineer', 324, 18);
insert into book (title, page_number, author_id) values ('Business Systems Development Analyst', 309, 28);
insert into book (title, page_number, author_id) values ('Community Outreach Specialist', 372, 20);
insert into book (title, page_number, author_id) values ('Information Systems Manager', 157, 3);
insert into book (title, page_number, author_id) values ('Programmer Analyst IV', 87, 27);
insert into book (title, page_number, author_id) values ('Web Developer IV', 319, 26);
insert into book (title, page_number, author_id) values ('Operator', 196, 38);
insert into book (title, page_number, author_id) values ('Engineer III', 209, 14);
insert into book (title, page_number, author_id) values ('Media Manager III', 321, 33);
insert into book (title, page_number, author_id) values ('Nuclear Power Engineer', 197, 14);
insert into book (title, page_number, author_id) values ('Desktop Support Technician', 226, 18);
insert into book (title, page_number, author_id) values ('Office Assistant II', 54, 13);
insert into book (title, page_number, author_id) values ('Senior Sales Associate', 233, 39);
insert into book (title, page_number, author_id) values ('Tax Accountant', 398, 32);
insert into book (title, page_number, author_id) values ('Civil Engineer', 77, 3);
insert into book (title, page_number, author_id) values ('Civil Engineer', 385, 37);
insert into book (title, page_number, author_id) values ('Help Desk Technician', 215, 1);
insert into book (title, page_number, author_id) values ('Quality Control Specialist', 57, 17);
insert into book (title, page_number, author_id) values ('VP Quality Control', 350, 17);
insert into book (title, page_number, author_id) values ('Assistant Media Planner', 67, 18);
insert into book (title, page_number, author_id) values ('VP Product Management', 370, 35);
insert into book (title, page_number, author_id) values ('Analyst Programmer', 290, 10);
insert into book (title, page_number, author_id) values ('Research Assistant I', 190, 27);
insert into book (title, page_number, author_id) values ('Food Chemist', 327, 31);
insert into book (title, page_number, author_id) values ('Financial Analyst', 191, 32);
insert into book (title, page_number, author_id) values ('Developer IV', 172, 29);
insert into book (title, page_number, author_id) values ('Data Coordiator', 261, 35);
insert into book (title, page_number, author_id) values ('Desktop Support Technician', 348, 27);
insert into book (title, page_number, author_id) values ('Safety Technician II', 214, 6);
insert into book (title, page_number, author_id) values ('Marketing Assistant', 270, 2);
insert into book (title, page_number, author_id) values ('Social Worker', 336, 32);
insert into book (title, page_number, author_id) values ('Marketing Assistant', 223, 17);
insert into book (title, page_number, author_id) values ('VP Accounting', 224, 23);
insert into book (title, page_number, author_id) values ('Health Coach IV', 198, 9);
insert into book (title, page_number, author_id) values ('Research Nurse', 161, 18);
insert into book (title, page_number, author_id) values ('Social Worker', 240, 31);
insert into book (title, page_number, author_id) values ('Recruiter', 234, 33);
insert into book (title, page_number, author_id) values ('Quality Control Specialist', 69, 7);
insert into book (title, page_number, author_id) values ('Senior Editor', 264, 15);
insert into book (title, page_number, author_id) values ('Senior Financial Analyst', 175, 13);
insert into book (title, page_number, author_id) values ('Paralegal', 233, 24);
insert into book (title, page_number, author_id) values ('Assistant Media Planner', 192, 11);
insert into book (title, page_number, author_id) values ('Clinical Specialist', 384, 9);
insert into book (title, page_number, author_id) values ('Geologist II', 306, 9);
insert into book (title, page_number, author_id) values ('Dental Hygienist', 242, 1);
insert into book (title, page_number, author_id) values ('Technical Writer', 262, 32);
insert into book (title, page_number, author_id) values ('Quality Engineer', 203, 22);
insert into book (title, page_number, author_id) values ('Marketing Manager', 308, 12);
insert into book (title, page_number, author_id) values ('Internal Auditor', 380, 33);
insert into book (title, page_number, author_id) values ('Human Resources Assistant I', 289, 7);
insert into book (title, page_number, author_id) values ('Accountant III', 199, 28);
insert into book (title, page_number, author_id) values ('Clinical Specialist', 295, 26);
insert into book (title, page_number, author_id) values ('Research Assistant IV', 108, 7);
insert into book (title, page_number, author_id) values ('Automation Specialist I', 183, 31);
insert into book (title, page_number, author_id) values ('Nuclear Power Engineer', 66, 10);
insert into book (title, page_number, author_id) values ('Nurse Practicioner', 178, 19);