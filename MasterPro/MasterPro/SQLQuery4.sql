----insert into
----userInfo
----values('3115004886', '�Ź���', 'admin', 'Master');
--update userInfo set u_name = '�Ź���' 
--where u_id = '3115004886';

--select *
--from userInfo;
----insert into
----masterInfo(m_id, m_name)
----values('3115004886', '�Ź���');
--update masterInfo set m_name = '�Ź���' 
--where m_id = '3115004886';
--select *
--from masterInfo;

--INSERT INTO
--userInfo
--VALUES('3115004886','�����','master','master');

--INSERT INTO
--masterInfo
--VALUES('3115004886','�����','��','1996-06-12',2015,'�����ѧԺ','�����ϵ','10001','�������ѧ�뼼��',3,1);

--INSERT INTO
--courseInfo
--VALUES('001','���ݿ�','�˹���','�����');

--INSERT INTO
--master_course
--VALUES('3115004885','001','311500', 99,'�˹���');

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

