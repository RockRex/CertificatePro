--数据库版本：SQLServer 2008R2
--建表时间：2016.11.15
--数据库名称 DbCertificatePro
--数据库账号：ZXC  数据库密码：123456


--会员信息
drop table userTable;
create table userTable(
userID nvarchar(20) not null,--账户
userPwd nvarchar(20) not null,--密码
userName nvarchar(30) not null,--姓名
userSex nvarchar(20) not null,--性别
userIdent nvarchar(20) not null,--身份
userDiploma nvarchar(20) not null,--学历
userPhone nvarchar(20) not null,--手机
userAddProvince nvarchar(20) not null,--地址_省
userAddCity nvarchar(20) not null,--地址_市
userAddArea nvarchar(20) not null,--地址_区
primary key(userID)
)

--临时传值的用户表
select * from userTable
delete from userTable

create table Users(
userID nvarchar(20) primary key
)
select * from Users
delete from Users

--报名表单
drop table signUp;
create table signUp(
upID nvarchar(20) not null,--账户
upName nvarchar(30) not null,--姓名
upSex nvarchar(20) not null,--性别
upDiploma nvarchar(20) not null,--学历
upCardClass nvarchar(20) not null,--证书类别
upCard nvarchar(20) not null,--证书
upSchool nvarchar(20),--预报培训点（可空）
upIdNum nvarchar(20) not null,--身份证号
upTel nvarchar(20),--电话（可空）
upPhone nvarchar(20) not null,--手机
upAddProvince nvarchar(20) not null,--地址_省
upAddCity nvarchar(20) not null,--地址_市
upAddArea nvarchar(20) not null,--地址_区
upNote nvarchar(1000) not null,--情况说明
primary key(upCard)
)
select * from signUp
delete from signUp

--证书表
drop table Qualifications;
create table Qualifications(
QuaType nvarchar(20) not null,--类别
QuaName nvarchar(20) not null,--证书名称
QuaCandidate nvarchar(30) not null,--报考时间
QuaRequirement nvarchar(1000),--报考条件
QuaCost nvarchar(30) not null,--报考费用
QuaTime nvarchar(20) not null,--考试时间
QuaCourse nvarchar(100),--考试科目
QuaAttention nvarchar(1000),--注意事项
)
insert into Qualifications values('资格认证','一','2016','1','1','1','1','1');
insert into Qualifications values('资格认证','二','2016','2','12','12','12','12');
delete from Qualifications
select * from Qualifications
--培训机构
drop table cardSchool;
create table cardSchool(
schoolName nvarchar(30) not null,--机构名称
schoolPassNum nvarchar(30) not null,--通过率
schoolCard nvarchar(30) not null,--证书类别
schoolNote nvarchar(1000) not null,--简介
schoolPerson nvarchar(30) not null,--负责人
schoolPhone nvarchar(30) not null,--联系方式（手机）
schoolEmail nvarchar(30) not null,--联系方式 邮箱
schoolProvince nvarchar(30) not null,--所在区域（省
schoolCity nvarchar(30) not null,--所在区域 市）
)
select * from cardSchool