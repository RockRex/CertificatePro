--���ݿ�汾��SQLServer 2008R2
--����ʱ�䣺2016.11.15
--���ݿ����� DbCertificatePro
--���ݿ��˺ţ�ZXC  ���ݿ����룺123456


--��Ա��Ϣ
drop table userTable;
create table userTable(
userID nvarchar(20) not null,--�˻�
userPwd nvarchar(20) not null,--����
userName nvarchar(30) not null,--����
userSex nvarchar(20) not null,--�Ա�
userIdent nvarchar(20) not null,--���
userDiploma nvarchar(20) not null,--ѧ��
userPhone nvarchar(20) not null,--�ֻ�
userAddProvince nvarchar(20) not null,--��ַ_ʡ
userAddCity nvarchar(20) not null,--��ַ_��
userAddArea nvarchar(20) not null,--��ַ_��
primary key(userID)
)

--��ʱ��ֵ���û���
select * from userTable
delete from userTable

create table Users(
userID nvarchar(20) primary key
)
select * from Users
delete from Users

--������
drop table signUp;
create table signUp(
upID nvarchar(20) not null,--�˻�
upName nvarchar(30) not null,--����
upSex nvarchar(20) not null,--�Ա�
upDiploma nvarchar(20) not null,--ѧ��
upCardClass nvarchar(20) not null,--֤�����
upCard nvarchar(20) not null,--֤��
upSchool nvarchar(20),--Ԥ����ѵ�㣨�ɿգ�
upIdNum nvarchar(20) not null,--���֤��
upTel nvarchar(20),--�绰���ɿգ�
upPhone nvarchar(20) not null,--�ֻ�
upAddProvince nvarchar(20) not null,--��ַ_ʡ
upAddCity nvarchar(20) not null,--��ַ_��
upAddArea nvarchar(20) not null,--��ַ_��
upNote nvarchar(1000) not null,--���˵��
primary key(upCard)
)
select * from signUp
delete from signUp

--֤���
drop table Qualifications;
create table Qualifications(
QuaType nvarchar(20) not null,--���
QuaName nvarchar(20) not null,--֤������
QuaCandidate nvarchar(30) not null,--����ʱ��
QuaRequirement nvarchar(1000),--��������
QuaCost nvarchar(30) not null,--��������
QuaTime nvarchar(20) not null,--����ʱ��
QuaCourse nvarchar(100),--���Կ�Ŀ
QuaAttention nvarchar(1000),--ע������
)
insert into Qualifications values('�ʸ���֤','һ','2016','1','1','1','1','1');
insert into Qualifications values('�ʸ���֤','��','2016','2','12','12','12','12');
delete from Qualifications
select * from Qualifications
--��ѵ����
drop table cardSchool;
create table cardSchool(
schoolName nvarchar(30) not null,--��������
schoolPassNum nvarchar(30) not null,--ͨ����
schoolCard nvarchar(30) not null,--֤�����
schoolNote nvarchar(1000) not null,--���
schoolPerson nvarchar(30) not null,--������
schoolPhone nvarchar(30) not null,--��ϵ��ʽ���ֻ���
schoolEmail nvarchar(30) not null,--��ϵ��ʽ ����
schoolProvince nvarchar(30) not null,--��������ʡ
schoolCity nvarchar(30) not null,--�������� �У�
)
select * from cardSchool