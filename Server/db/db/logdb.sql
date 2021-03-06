if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[P_music_record]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[P_music_record]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[P_playtime_sum]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[P_playtime_sum]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[P_sdo_load_hiscore]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[P_sdo_load_hiscore]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[P_sdo_update_hiscore]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[P_sdo_update_hiscore]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Sort_User]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Sort_User]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_login_logout_record]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[T_login_logout_record]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_music_record]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[T_music_record]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_sdo_hiscore]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[T_sdo_hiscore]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_send_record]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[T_send_record]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[T_shop_record]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[T_shop_record]
GO

CREATE TABLE [dbo].[Sort_User] (
	[User_ID] [int] IDENTITY (1, 1) NOT NULL ,
	[User_Server] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[User_Nick] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[User_Level] [int] NULL ,
	[User_Experience] [int] NULL ,
	[User_Battle] [int] NULL ,
	[User_Win] [int] NULL ,
	[User_Draw] [int] NULL ,
	[User_Lose] [int] NULL ,
	[User_Perfect] [int] NULL ,
	[User_Cool] [int] NULL ,
	[User_Bad] [int] NULL ,
	[User_Miss] [int] NULL ,
	[User_Click] [varchar] (5) COLLATE Chinese_PRC_CI_AS NULL ,
	[User_Fluctuation] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[T_login_logout_record] (
	[UserIndexID] [int] NOT NULL ,
	[userid] [char] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[logintime] [smalldatetime] NOT NULL ,
	[logouttime] [smalldatetime] NOT NULL ,
	[IPAddress] [char] (20) COLLATE Chinese_Taiwan_Stroke_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[T_music_record] (
	[MusicID] [int] NOT NULL ,
	[easy] [int] NOT NULL ,
	[normal] [int] NOT NULL ,
	[hard] [int] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[T_sdo_hiscore] (
	[UserIndexID] [int] NOT NULL ,
	[MusicID] [int] NOT NULL ,
	[mode] [tinyint] NOT NULL ,
	[difficulty] [tinyint] NOT NULL ,
	[perfect] [int] NOT NULL ,
	[cool] [int] NOT NULL ,
	[bad] [int] NOT NULL ,
	[miss] [int] NOT NULL ,
	[maxCombo] [int] NOT NULL ,
	[finalScore] [int] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[T_send_record] (
	[sendtime] [datetime] NOT NULL ,
	[senderIndexID] [int] NOT NULL ,
	[senderUserID] [char] (12) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[receiverNick] [char] (16) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[itemcode] [int] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[T_shop_record] (
	[shoptime] [datetime] NOT NULL ,
	[UserIndexID] [int] NOT NULL ,
	[userid] [char] (12) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[ProductID] [int] NOT NULL ,
	[ProductName] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[moneycost] [int] NOT NULL ,
	[moneytype] [tinyint] NOT NULL 
) ON [PRIMARY]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE P_music_record
 @MusicID	int
,@MusicLevel	tinyint
AS

	IF NOT EXISTS(SELECT MusicID FROM T_music_record WHERE MusicID=@MusicID)
		INSERT INTO T_music_record VALUES (@MusicID,0,0,0)

	IF @MusicLevel = 0
		UPDATE T_music_record SET easy=easy+1 WHERE MusicID=@MusicID
	ELSE IF @MusicLevel = 1
		UPDATE T_music_record SET [normal]=[normal]+1 WHERE MusicID=@MusicID
	ELSE IF @MusicLevel = 2
		UPDATE T_music_record SET hard=hard+1 WHERE MusicID=@MusicID


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE  PROCEDURE P_playtime_sum
 @starttime	smalldatetime
,@endtime	smalldatetime
AS

	SELECT userid, SUM(DATEDIFF(mi,logintime,logouttime)) AS PLAYTIME
	FROM T_login_logout_record
	WHERE logintime>@starttime AND logouttime<@endtime
	GROUP BY userid ORDER BY PLAYTIME DESC



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE  PROCEDURE P_sdo_load_hiscore
@UserIndexID	int,
@bMode		int,
@bDifficulty	int
AS
	SELECT * FROM T_sdo_hiscore
	WHERE UserIndexID = @UserIndexID AND mode = @bMode AND difficulty = @bDifficulty



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO



CREATE           PROCEDURE P_sdo_update_hiscore
 @UserIndexID	int
,@Perfect	int
,@Cool		int
,@Bad		int
,@Miss		int
,@MaxCombo	int
,@FinalScore	int
,@musicID	int
,@mode		tinyint
,@difficulty	tinyint
AS
	
	DECLARE @oldscore int
	SET @oldscore = 0
	
	BEGIN
		IF EXISTS(SELECT finalScore FROM T_sdo_hiscore
			WHERE UserIndexID=@UserIndexID AND MusicID=@musicID AND mode=@mode AND difficulty=@difficulty)
		BEGIN
			SELECT @oldscore=finalScore FROM T_sdo_hiscore
				WHERE UserIndexID=@UserIndexID AND MusicID=@musicID AND mode=@mode AND difficulty=@difficulty
			IF @FinalScore > @oldscore
			BEGIN
				UPDATE T_sdo_hiscore
				SET perfect = @Perfect,
					cool = @Cool,
					bad = @Bad,
					miss = @Miss,
					maxCombo = @MaxCombo,
					finalScore = @FinalScore
				WHERE UserIndexID=@UserIndexID AND MusicID=@musicID AND mode=@mode AND difficulty=@difficulty
			END
		END
		ELSE
		BEGIN
			INSERT INTO T_sdo_hiscore VALUES
				(@UserIndexID,@musicID,@mode,@difficulty,@Perfect,@Cool,@Bad,@Miss,@MaxCombo,@FinalScore)
		END
	END
	



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

