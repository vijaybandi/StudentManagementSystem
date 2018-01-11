----insert into
----userInfo
----values('3115004886', '张国荣', 'admin', 'Master');
--update userInfo set u_name = '张国荣' 
--where u_id = '3115004886';

--select *
--from userInfo;
----insert into
----masterInfo(m_id, m_name)
----values('3115004886', '张国荣');
--update masterInfo set m_name = '张国荣' 
--where m_id = '3115004886';
--select *
--from masterInfo;

--INSERT INTO
--userInfo
--VALUES('3115004886','刘广大','master','master');

--INSERT INTO
--masterInfo
--VALUES('3115004886','刘广大','男','1996-06-12',2015,'计算机学院','计算机系','10001','计算机科学与技术',3,1);

--INSERT INTO
--courseInfo
--VALUES('001','数据库','顾国生','计算机');

--INSERT INTO
--master_course
--VALUES('3115004885','001','311500', 99,'顾国生');

select masterInfo.m_id, m_name, courseInfo.c_id, c_name, score
from masterInfo, courseInfo, master_course
where masterInfo.m_id = master_course.m_id
and courseInfo.c_id = master_course.c_id;


select masterInfo.m_id, m_name, courseInfo.c_id, c_name, score 
from masterInfo, courseInfo, master_course
where masterInfo.m_id = '3115004885'  
and masterInfo.m_id = master_course.m_id
and courseInfo.c_id = master_course.c_id;

--delete from master_course where m_id = '3115004888';
--delete from masterInfo where m_id = '3115004888';
--delete from userInfo where u_id = '3115004888';

