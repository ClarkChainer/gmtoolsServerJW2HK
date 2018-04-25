use gmtools
insert into dbo.department(departname,remark) values('GM管理中心','GM管理中心')
insert into dbo.gamelist(game_name,game_content) values('GM管理工具','GM管理工具')
insert into dbo.gamelist(game_name,game_content) values('光線飛車','光線飛車')


insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('1','用戶管理','AccountList','用戶管理')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('1','修改密码','UserSelfEditPwd','修改密码')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('1','模块管理','ModuleList','模块管理')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','激活码查询管理','FrmRcCodeQuery','激活码查询管理')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','添加游戏币','FrmAddMoney','添加游戏币')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','连接状态查询','FrmConnectionState','连接状态查询')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','公会信息查询','FrmGuildQuery','公会信息查询')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','MissionLog','FrmMissionLog','MissionLog')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','MoneyLog','FrmMoneyLog','MoneyLog')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','车辆信息查询','FrmQueryPlayerCar','车辆信息查询')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','玩家角色信息','FrmQueryPlayerChinfo','玩家角色信息')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','购买信息查询','FrmConnectionState','购买信息查询')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','好友列表','FrmQueryPlayerFriend','好友列表')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','玩家道具信息','FrmPlayGiftInfo','玩家道具信息')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','帐号信息查询','FrmQueryPlayerID','帐号信息查询')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','任务信息查询','FrmQueryPlayerQuestLog','任务信息查询')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','技能信息','FrmQueryPlayerSkill','技能信息')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','登陆记录','FrmQueryPlayerState','登陆记录')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','比赛查询','FrmQueryRaceState','比赛查询')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','RaceLog','FrmRaceLog','RaceLog')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','GM帐号信息','FrmRCGmaccont','GM帐号信息')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','玩家角色位置重置','FrmPlayerPosition','玩家角色位置重置')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','玩家交易记录信息','FrmPlayerTradeLog','玩家交易记录信息')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','重置仓库密码','FrmWarePassword','重置仓库密码')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','合成道具记录','FrmBingoCard','合成道具记录')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','充值信息查询','FrmQueryPlayerMlog','充值信息查询')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','邮件记录查询','FrmQueryMailLog','邮件记录查询')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','个人消费记录查询','FrmQueryMCashLog','个人消费记录查询')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','玩家序列号查询','FrmCoupon','玩家序列号查询')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','查询游戏内GM帐号信息','FrmPlayGiftInfo','查询游戏内GM帐号信息')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','游戏GM信息查询','FrmGameGmQuery','游戏GM信息查询')
insert into dbo.gmtools_modules(game_id,module_Name,module_class,module_content) values('2','光线飞车公告','FrmRCNotice','光线飞车公告')

insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','1','1')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','2','1')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','3','1')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','4','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','5','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','6','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','7','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','8','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','9','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','10','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','12','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','13','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','14','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','15','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','16','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','17','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','18','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','19','1')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','20','1')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','21','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','22','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','23','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','24','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','25','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','26','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','27','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','28','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','29','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','30','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','31','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','32','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','33','2')
insert into dbo.gmtools_roles(userid,module_id,game_id) values('1','34','2')

insert into gmtools_users(username,user_pwd,realname,departid,user_status,limit,onlineactive,sysadmin) values('admin','C4-CA-42-38-A0-B9-23-82-0D-CC-50-9A-6F-75-84-9B','GM管理員','1','1','2009-10-20','0','1')
insert into gmtools_serverinfo(serverip,city,gameID,gamename,gameflag,gamedbid,descinfo) values('124.74.198.168','测试1','2','光線飛車','1','1','GAMEDB')
insert into gmtools_serverinfo(serverip,city,gameID,gamename,gameflag,gamedbid,descinfo) values('192.168.49.239','测试1','2','光線飛車','1','2','MEMBER')
insert into gmtools_serverinfo(serverip,city,gameID,gamename,gameflag,gamedbid,descinfo) values('192.168.49.239','测试1','2','光線飛車','1','3','LOG')
--insert into sqlexpress(sql_type,sql_field,sql_statement,sql_condition) values('AU2_ACCOUNT_QUERY','AU2帳戶查詢','select a.UserSn as au2_usersn,a.UserNick as au2_usernick,a.UserID as au2_userid,a.Gender as au2_sex,b.level as au2_level,b.exp as au2_exp,b.cash as au2_cash,b.money as au2_money from game_db.Userinfo a,game_db.userextendinfo b where a.usersn=b.usersn and a.usersn=%i','AU2帳戶查詢')
