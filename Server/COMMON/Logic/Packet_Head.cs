using System;

namespace Common.Logic
{
	/// <summary>
	/// Packet_Head ��ժҪ˵����
	/// </summary>
	public enum Msg_Category:byte
	{
		COMMON = 0x80,//������Ϣ��
		USER_ADMIN = 0x81,//GM�ʺŲ�����Ϣ��
		MODULE_ADMIN = 0x82,//ģ�������Ϣ��
		USER_MODULE_ADMIN = 0x83,//�û���ģ�������Ϣ��
		GAME_ADMIN = 0x84, //��Ϸģ�������Ϣ��
		NOTES_ADMIN = 0x85,//NOTESģ�������Ϣ��
		MJ_ADMIN = 0x86,//�ͽ�GM���߲�����Ϣ��
		SDO_ADMIN = 0x87,//�������߲�����Ϣ��
		AU_ADMIN = 0x88,//�����Ų�����Ϣ��
		CR_ADMIN = 0x89,//��񿨶���������Ϣ��
		CARD_ADMIN = 0x90,//�û���ֵ���Ѽ�¼��Ϣ��
		AUSHOP_ADMIN = 0x91,//�������̳Ǽ�¼��Ϣ��
		O2JAM_ADMIN = 0x92,//�����ż�¼��Ϣ��
		O2JAM2_ADMIN = 0x93,//������II��¼��Ϣ��
		SOCCER_ADMIN = 0x94,//���������¼��Ϣ��
		FJ_ADMIN = 0x95,//���֮�ü�¼��Ϣ��
		RC_ADMIN = 0x96,//���쮳���¼��Ϣ��
		RAYCITY_ADMIN = 0x97,//���߷ɳ���¼��Ϣ��
		RICH_ADMIN = 0x98,//���̼�¼��Ϣ��
		MF_ADMIN  = 0x99,//����ɭ�ּ�¼��Ϣ��
		SD_ADMIN = 0x70,//SD�ߴ��¼��Ϣ��
		MAGIC_ADMIN = 0x71,//ħ������2��¼��Ϣ��
		STLQ_ADMIN = 0x72,//���������¼��Ϣ��
		LORD_ADMIN=0x73,//����ONLINE��¼��Ϣ��
		SanGo_ADMIN=0x74,//��������ȺӢ��¼��Ϣ��
		Pal_ADMIN=0x75,//�ɽ�OL��¼��Ϣ��
		AU_OLD_ADMIN = 0x76,//�����Ż��ɰ�

        JW2_ADMIN=0x61,//������II
		ERROR = 0xFF
	}
	public enum	ServiceKey:ushort
	{
		/// <summary>
		/// ����ģ��(0x80)
		/// </summary>
		CONNECT = 0x0001,
		CONNECT_RESP = 0x8001,
		DISCONNECT = 0x0002,
		DISCONNECT_RESP = 0x8002,
		ACCOUNT_AUTHOR = 0x0003,
		ACCOUNT_AUTHOR_RESP = 0x8003,
		SERVERINFO_IP_QUERY = 0x0004,
		SERVERINFO_IP_QUERY_RESP = 0x8004,
		GMTOOLS_OperateLog_Query = 0x0005,//�鿴���߲�����¼
		GMTOOLS_OperateLog_Query_RESP = 0x8005,//�鿴���߲�����¼��Ӧ
		SERVERINFO_IP_ALL_QUERY = 0x0006,//�鿴������Ϸ��������ַ
		SERVERINFO_IP_ALL_QUERY_RESP = 0x8006,//�鿴������Ϸ��������ַ��Ӧ
		LINK_SERVERIP_CREATE = 0x0007,//������Ϸ�������ݿ�
		LINK_SERVERIP_CREATE_RESP = 0x8007,//������Ϸ�������ݿ���Ӧ
		CLIENT_PATCH_COMPARE = 0x0008,
		CLIENT_PATCH_COMPARE_RESP = 0x8008,
		CLIENT_PATCH_UPDATE = 0x0009,
		CLIENT_PATCH_UPDATE_RESP = 0x8009,
		LINK_SERVERIP_DELETE = 0x0010,
		LINK_SERVERIP_DELETE_RESP = 0x8010,
		GMTOOLS_BUGLIST_QUERY = 0x0011,
		GMTOOLS_BUGLIST_QUERY_RESP = 0x8011,
		GMTOOLS_BUGLIST_INSERT = 0x0012,
		GMTOOLS_BUGLIST_INSERT_RESP = 0x8012,
		GMTOOLS_BUGLIST_UPDATE = 0x0013,
		GMTOOLS_BUGLIST_UPDATE_RESP = 0x8013,
		GMTOOLS_UPDATELIST_QUERY = 0x0014,
		GMTOOLS_UPDATELIST_QUERY_RESP = 0x8014,
		GMTOOLS_RESETSTATICS_QUERY = 0x0015,
		GMTOOLS_RESETSTATICS_QUERY_RESP = 0x8015,
		GMTOOLS_USERMAC_UPDATE = 0x0016,
		GMTOOLS_USERMAC_UPDATE_RESP = 0x8016,
		SERVERINFO_FJIP_QUERY = 0x0017,
		SERVERINFO_FJIP_QUERY_RESP = 0x8017,
		AU_MsgServerinfo_Query= 0x0018,
		AU_MsgServerinfo_Query_RESP = 0x8018,
		SDO_RemoteIp_Query = 0x0019,
		SDO_RemoteIp_Query_RESP = 0x8019,

		/// <summary>
		///�û�����ģ��(0x81) 
		/// </summary>
		USER_CREATE = 0x0001,
		USER_CREATE_RESP = 0x8001,
		USER_UPDATE = 0x0002,
		USER_UPDATE_RESP = 0x8002,
		USER_DELETE = 0x0003,
		USER_DELETE_RESP = 0x8003,
		USER_QUERY = 0x0004,
		USER_QUERY_RESP = 0x8004,
		USER_PASSWD_MODIF = 0x0005,
		USER_PASSWD_MODIF_RESP = 0x8005,
		USER_QUERY_ALL = 0x0006,
		USER_QUERY_ALL_RESP = 0x8006,
		DEPART_QUERY = 0x0007,
		DEPART_QUERY_RESP = 0x8007,
		UPDATE_ACTIVEUSER = 0x0008,//���������û�״̬
		UPDATE_ACTIVEUSER_RESP = 0x8008,//���������û�״̬��Ӧ
		DEPARTMENT_CREATE = 0x0009,//���Ŵ���
		DEPARTMENT_CREATE_RESP = 0x8009,//���Ŵ�����Ӧ
		DEPARTMENT_UPDATE= 0x0010,//�����޸�
		DEPARTMENT_UPDATE_RESP = 0x8010,//�����޸���Ӧ
		DEPARTMENT_DELETE= 0x0011,//����ɾ��
		DEPARTMENT_DELETE_RESP = 0x8011,//����ɾ����Ӧ
		DEPARTMENT_ADMIN = 0x0012,//���Ź���
		DEPARTMENT_ADMIN_RESP = 0x8012,//���Ź�����Ӧ
		DEPARTMENT_RELATE_QUERY = 0x0013,//���Ź�����ѯ
		DEPARTMENT_RELATE_QUERY_RESP = 0x8013,//���Ź�����ѯ
		DEPART_RELATE_GAME_QUERY = 0x0014,
		DEPART_RELATE_GAME_QUERY_RESP = 0x8014,
		USER_SYSADMIN_QUERY = 0x0015,
		USER_SYSADMIN_QUERY_RESP = 0x8015,
		USERBAN_QUERY = 0x0016,
		USERBAN_QUERY_RESP = 0x8016,


		/// <summary>
		/// ģ�����(0x82)
		/// </summary>
		MODULE_CREATE = 0x0001,
		MODULE_CREATE_RESP = 0x8001,
		MODULE_UPDATE = 0x0002,
		MODULE_UPDATE_RESP = 0x8002,
		MODULE_DELETE = 0x0003,
		MODULE_DELETE_RESP = 0x8003,
		MODULE_QUERY = 0x0004,
		MODULE_QUERY_RESP = 0x8004,

		/// <summary>
		/// �û���ģ��(0x83) 
		/// </summary>
		USER_MODULE_CREATE = 0x0001,
		USER_MODULE_CREATE_RESP = 0x8001,
		USER_MODULE_UPDATE = 0x0002,
		USER_MODULE_UPDATE_RESP = 0x8002,
		USER_MODULE_DELETE = 0x0003,
		USER_MODULE_DELETE_RESP = 0x8003,
		USER_MODULE_QUERY= 0x0004,
		USER_MODULE_QUERY_RESP = 0x8004,

		/// <summary>
		/// ��Ϸ����(0x84) 
		/// </summary>
		GAME_CREATE = 0x0001,
		GAME_CREATE_RESP = 0x8001,
		GAME_UPDATE = 0x0002,
		GAME_UPDATE_RESP = 0x8002,
		GAME_DELETE = 0x0003,
		GAME_DELETE_RESP = 0x8003,
		GAME_QUERY = 0x0004,
		GAME_QUERY_RESP = 0x8004,
		GAME_MODULE_QUERY = 0x0005,
		GAME_MODULE_QUERY_RESP = 0x8005,

		/// <summary>
		/// NOTES����(0x85) 
		/// </summary>
		NOTES_LETTER_TRANSFER = 0x0001,
		NOTES_LETTER_TRANSFER_RESP = 0x8001,
		NOTES_LETTER_PROCESS = 0x0002, //�ʼ�����
		NOTES_LETTER_PROCESS_RESP = 0x8002,//�ʼ�����
		NOTES_LETTER_TRANSMIT = 0x0003,//�ʼ�ת��
		NOTES_LETTER_TRANSMIT_RESP = 0x8003,//�ʼ�ת����Ӧ
		NOTES_LINKER_GET = 0x0004,
		NOTES_LINKER_GET_RESP = 0x8004,
		NOTES_CONTENT_GET = 0x0005,
		NOTES_CONTENT_GET_RESP = 0x8005,
		NOTES_CONTENT_SEND = 0x0006,
		NOTES_CONTENT_SEND_RESP = 0x8006,
		NOTES_CONTENT_REPLAY =  0x0007,
		NOTES_CONTENT_REPLAY_RESP = 0x8007,
		NOTES_ATTACHMENT_GET = 0x0008,
		NOTES_ATTACHMENT_GET_RESP = 0x8008,
		NOTES_CONTENT_UPDATE = 0x0009,
		NOTES_CONTENT_UPDATE_RESP = 0x8009,
		NOTES_CONTENT_DELETE = 0x0010,
		NOTES_CONTENT_DELETE_RESP = 0x8010,

        
		/// <summary>
		/// �ͽ�GM���߹���(0x86)
		/// </summary>
		MJ_CHARACTERINFO_QUERY = 0x0001,//������״̬
		MJ_CHARACTERINFO_QUERY_RESP = 0x8001,//������״̬��Ӧ
		MJ_CHARACTERINFO_UPDATE = 0x0002,//�޸����״̬
		MJ_CHARACTERINFO_UPDATE_RESP = 0x8002,//�޸����״̬��Ӧ
		MJ_LOGINTABLE_QUERY = 0x0003,//�������Ƿ�����
		MJ_LOGINTABLE_QUERY_RESP = 0x8003,//�������Ƿ�������Ӧ
		MJ_CHARACTERINFO_EXPLOIT_UPDATE = 0x0004,//�޸Ĺ�ѫֵ
		MJ_CHARACTERINFO_EXPLOIT_UPDATE_RESP = 0x8004,//�޸Ĺ�ѫֵ��Ӧ
		MJ_CHARACTERINFO_FRIEND_QUERY = 0x0005,//�г���������
		MJ_CHARACTERINFO_FRIEND_QUERY_RESP = 0x8005,//�г�����������Ӧ
		MJ_CHARACTERINFO_FRIEND_CREATE = 0x0006,//���Ӻ���
		MJ_CHARACTERINFO_FRIEND_CREATE_RESP = 0x8006,//���Ӻ�����Ӧ
		MJ_CHARACTERINFO_FRIEND_DELETE = 0x0007,//ɾ������
		MJ_CHARACTERINFO_FRIEND_DELETE_RESP = 0x8007,//ɾ��������Ӧ
		MJ_GUILDTABLE_UPDATE = 0x0008,//�޸ķ����������Ѵ��ڰ��
		MJ_GUILDTABLE_UPDATE_RESP = 0x8008,//�޸ķ����������Ѵ��ڰ����Ӧ
		MJ_ACCOUNT_LOCAL_CREATE = 0x0009,//���������ϵ�account����������Ϣ���浽���ط�������
		MJ_ACCOUNT_LOCAL_CREATE_RESP = 0x8009,//���������ϵ�account����������Ϣ���浽���ط���������Ӧ
		MJ_ACCOUNT_REMOTE_DELETE = 0x0010,//���÷�ͣ�ʺ�
		MJ_ACCOUNT_REMOTE_DELETE_RESP = 0x8010,//���÷�ͣ�ʺŵ���Ӧ
		MJ_ACCOUNT_REMOTE_RESTORE = 0x0011,//����ʺ�
		MJ_ACCOUNT_REMOTE_RESTORE_RESP = 0x8011,//����ʺ���Ӧ
		MJ_ACCOUNT_LIMIT_RESTORE = 0x0012,//��ʱ�޵ķ�ͣ
		MJ_ACCOUNT_LIMIT_RESTORE_RESP = 0x8012,//��ʱ�޵ķ�ͣ��Ӧ
		MJ_ACCOUNTPASSWD_LOCAL_CREATE = 0x0013,//����������뵽���� 
		MJ_ACCOUNTPASSWD_LOCAL_CREATE_RESP = 0x8013,//����������뵽����
		MJ_ACCOUNTPASSWD_REMOTE_UPDATE = 0x0014,//�޸�������� 
		MJ_ACCOUNTPASSWD_REMOTE_UPDATE_RESP = 0x8014,//�޸��������
		MJ_ACCOUNTPASSWD_REMOTE_RESTORE = 0x0015,//�ָ��������
		MJ_ACCOUNTPASSWD_REMOTE_RESTORE_RESP = 0x8015,//�ָ��������
		MJ_ITEMLOG_QUERY = 0x0016,//�����û����׼�¼
		MJ_ITEMLOG_QUERY_RESP = 0x8016,//�����û����׼�¼
		MJ_GMTOOLS_LOG_QUERY = 0x0017,//���ʹ���߲�����¼
		MJ_GMTOOLS_LOG_QUERY_RESP = 0x8017,//���ʹ���߲�����¼
		MJ_MONEYSORT_QUERY = 0x0018,//���ݽ�Ǯ����
		MJ_MONEYSORT_QUERY_RESP = 0x8018,//���ݽ�Ǯ�������Ӧ
		MJ_LEVELSORT_QUERY = 0x0019,//���ݵȼ�����
		MJ_LEVELSORT_QUERY_RESP = 0x8019,//���ݵȼ��������Ӧ
		MJ_MONEYFIGHTERSORT_QUERY = 0x0020,//���ݲ�ְͬҵ��Ǯ����
		MJ_MONEYFIGHTERSORT_QUERY_RESP = 0x8020,//���ݲ�ְͬҵ��Ǯ�������Ӧ
		MJ_LEVELFIGHTERSORT_QUERY = 0x0021,//���ݲ�ְͬҵ�ȼ�����
		MJ_LEVELFIGHTERSORT_QUERY_RESP = 0x8021,//���ݲ�ְͬҵ�ȼ��������Ӧ
		MJ_MONEYTAOISTSORT_QUERY = 0x0022,//���ݵ�ʿ��Ǯ����
		MJ_MONEYTAOISTSORT_QUERY_RESP = 0x8022,//���ݵ�ʿ��Ǯ�������Ӧ
		MJ_LEVELTAOISTSORT_QUERY = 0x0023,//���ݵ�ʿ�ȼ�����
		MJ_LEVELTAOISTSORT_QUERY_RESP = 0x8023,//���ݵ�ʿ�ȼ��������Ӧ
		MJ_MONEYRABBISORT_QUERY = 0x0024,//���ݷ�ʦ��Ǯ����
		MJ_MONEYRABBISORT_QUERY_RESP = 0x8024,//���ݷ�ʦ��Ǯ�������Ӧ
		MJ_LEVELRABBISORT_QUERY = 0x0025,//���ݷ�ʦ�ȼ�����
		MJ_LEVELRABBISORT_QUERY_RESP = 0x8025,//���ݷ�ʦ�ȼ��������Ӧ
		MJ_ACCOUNT_QUERY =  0x0026,//�ͽ��ʺŲ�ѯ
		MJ_ACCOUNT_QUERY_RESP = 0x8026,//�ͽ��ʺŲ�ѯ��Ӧ
		MJ_ACCOUNT_LOCAL_QUERY = 0x0027,//��ѯ�ͽ������ʺ�
		MJ_ACCOUNT_LOCAL_QUERY_RESP = 0x8027,//��ѯ�ͽ������ʺ���Ӧ

		/// <summary>
		/// SDO_ADMIN �������߹��߲�����Ϣ��
		/// </summary>
		SDO_ACCOUNT_QUERY = 0x0026,//�鿴��ҵ��ʺ���Ϣ
		SDO_ACCOUNT_QUERY_RESP = 0x8026,//�鿴��ҵ��ʺ���Ϣ��Ӧ
		SDO_CHARACTERINFO_QUERY = 0x0027,//�鿴�������ϵ���Ϣ
		SDO_CHARACTERINFO_QUERY_RESP = 0x8027,//�鿴�������ϵ���Ϣ��Ӧ
		SDO_ACCOUNT_CLOSE = 0x0028,//��ͣ�ʻ���Ȩ����Ϣ
		SDO_ACCOUNT_CLOSE_RESP = 0x8028,//��ͣ�ʻ���Ȩ����Ϣ��Ӧ
		SDO_ACCOUNT_OPEN = 0x0029,//����ʻ���Ȩ����Ϣ
		SDO_ACCOUNT_OPEN_RESP = 0x8029,//����ʻ���Ȩ����Ϣ��Ӧ
		SDO_PASSWORD_RECOVERY = 0x0030,//����һ�����
		SDO_PASSWORD_RECOVERY_RESP = 0x8030,//����һ�������Ӧ
		SDO_CONSUME_QUERY = 0x0031,//�鿴��ҵ����Ѽ�¼
		SDO_CONSUME_QUERY_RESP = 0x8031,//�鿴��ҵ����Ѽ�¼��Ӧ
		SDO_USERONLINE_QUERY = 0x0032,//�鿴���������״̬
		SDO_USERONLINE_QUERY_RESP = 0x8032,//�鿴���������״̬��Ӧ
		SDO_USERTRADE_QUERY = 0x0033,//�鿴��ҽ���״̬
		SDO_USERTRADE_QUERY_RESP = 0x8033,//�鿴��ҽ���״̬��Ӧ
		SDO_CHARACTERINFO_UPDATE = 0x0034,//�޸���ҵ��˺���Ϣ
		SDO_CHARACTERINFO_UPDATE_RESP = 0x8034,//�޸���ҵ��˺���Ϣ��Ӧ
		SDO_ITEMSHOP_QUERY = 0x0035,//�鿴��Ϸ�������е�����Ϣ
		SDO_ITEMSHOP_QUERY_RESP = 0x8035,//�鿴��Ϸ�������е�����Ϣ��Ӧ
		SDO_ITEMSHOP_DELETE = 0x0036,//ɾ����ҵ�����Ϣ
		SDO_ITEMSHOP_DELETE_RESP  = 0x8036,//ɾ����ҵ�����Ϣ��Ӧ
		SDO_GIFTBOX_CREATE  = 0x0037,//�����������е�����Ϣ
		SDO_GIFTBOX_CREATE_RESP  = 0x8037,//�����������е�����Ϣ��Ӧ
		SDO_GIFTBOX_QUERY = 0x0038,//�鿴�������еĵ���
		SDO_GIFTBOX_QUERY_RESP = 0x8038,//�鿴�������еĵ�����Ӧ
		SDO_GIFTBOX_DELETE = 0x0039,//ɾ���������еĵ���
		SDO_GIFTBOX_DELETE_RESP = 0x8039,//ɾ���������еĵ�����Ӧ
		SDO_USERLOGIN_STATUS_QUERY = 0x0040,//�鿴��ҵ�¼״̬
		SDO_USERLOGIN_STATUS_QUERY_RESP = 0x8040,//�鿴��ҵ�¼״̬��Ӧ
		SDO_ITEMSHOP_BYOWNER_QUERY = 0x0041,////�鿴������ϵ�����Ϣ
		SDO_ITEMSHOP_BYOWNER_QUERY_RESP = 0x8041,////�鿴������ϵ�����Ϣ
		SDO_ITEMSHOP_TRADE_QUERY = 0x0042,//�鿴��ҽ��׼�¼��Ϣ
		SDO_ITEMSHOP_TRADE_QUERY_RESP = 0x8042,//�鿴��ҽ��׼�¼��Ϣ����Ӧ
		SDO_MEMBERSTOPSTATUS_QUERY = 0x0043,//�鿴���ʺ�״̬
		SDO_MEMBERSTOPSTATUS_QUERY_RESP = 0x8043,///�鿴���ʺ�״̬����Ӧ
		SDO_MEMBERBANISHMENT_QUERY = 0x0044,//�鿴����ͣ����ʺ�
		SDO_MEMBERBANISHMENT_QUERY_RESP = 0x8044,//�鿴����ͣ����ʺ���Ӧ
		SDO_USERMCASH_QUERY = 0x0045,//��ҳ�ֵ��¼��ѯ
		SDO_USERMCASH_QUERY_RESP = 0x8045,//��ҳ�ֵ��¼��ѯ��Ӧ
		SDO_USERGCASH_UPDATE = 0x0046,//�������G��
		SDO_USERGCASH_UPDATE_RESP = 0x8046,//�������G�ҵ���Ӧ
		SDO_MEMBERLOCAL_BANISHMENT = 0x0047,//���ر���ͣ����Ϣ
		SDO_MEMBERLOCAL_BANISHMENT_RESP = 0x8047,//���ر���ͣ����Ϣ��Ӧ
		SDO_EMAIL_QUERY = 0x0048,//�õ���ҵ�EMAIL
		SDO_EMAIL_QUERY_RESP = 0x8048,//�õ���ҵ�EMAIL��Ӧ
		SDO_USERCHARAGESUM_QUERY = 0x0049,//�õ���ֵ��¼�ܺ�
		SDO_USERCHARAGESUM_QUERY_RESP = 0x8049,//�õ���ֵ��¼�ܺ���Ӧ
		SDO_USERCONSUMESUM_QUERY = 0x0050,//�õ����Ѽ�¼�ܺ�
		SDO_USERCONSUMESUM_QUERY_RESP = 0x8050,//�õ����Ѽ�¼�ܺ���Ӧ
		SDO_USERGCASH_QUERY = 0x0051,//��ңǱҼ�¼��ѯ
		SDO_USERGCASH_QUERY_RESP = 0x8051,//��ңǱҼ�¼��ѯ��Ӧ
		SDO_CHALLENGE_QUERY = 0x0052,
		SDO_CHALLENGE_QUERY_RESP = 0x8052,
		SDO_CHALLENGE_INSERT = 0x0053,
		SDO_CHALLENGE_INSERT_RESP = 0x8053,
		SDO_CHALLENGE_UPDATE = 0x0054,
		SDO_CHALLENGE_UPDATE_RESP = 0x8054,
		SDO_CHALLENGE_DELETE = 0x0055,
		SDO_CHALLENGE_DELETE_RESP = 0x8055,
		SDO_MUSICDATA_QUERY = 0x0056,
		SDO_MUSICDATA_QUERY_RESP = 0x8056,
		SDO_MUSICDATA_OWN_QUERY = 0x0057,
		SDO_MUSICDATA_OWN_QUERY_RESP = 0x8057,
		SDO_CHALLENGE_SCENE_QUERY = 0x0058,
		SDO_CHALLENGE_SCENE_QUERY_RESP = 0x8058,
		SDO_CHALLENGE_SCENE_CREATE = 0x0059,
		SDO_CHALLENGE_SCENE_CREATE_RESP = 0x8059,
		SDO_CHALLENGE_SCENE_UPDATE = 0x0060,
		SDO_CHALLENGE_SCENE_UPDATE_RESP = 0x8060,
		SDO_CHALLENGE_SCENE_DELETE = 0x0061,
		SDO_CHALLENGE_SCENE_DELETE_RESP = 0x8061,
		SDO_MEDALITEM_CREATE = 0x0062,
		SDO_MEDALITEM_CREATE_RESP = 0x8062,
		SDO_MEDALITEM_UPDATE = 0x0063,
		SDO_MEDALITEM_UPDATE_RESP = 0x8063,
		SDO_MEDALITEM_DELETE = 0x0064,
		SDO_MEDALITEM_DELETE_RESP = 0x8064,
		SDO_MEDALITEM_QUERY = 0x0065,
		SDO_MEDALITEM_QUERY_RESP = 0x8065,
		SDO_MEDALITEM_OWNER_QUERY = 0x0066,
		SDO_MEDALITEM_OWNER_QUERY_RESP = 0x8066,
		SDO_MEMBERDANCE_OPEN = 0x0067,
		SDO_MEMBERDANCE_OPEN_RESP = 0x8067,
		SDO_MEMBERDANCE_CLOSE = 0x0068,
		SDO_MEMBERDANCE_CLOSE_RESP = 0x8068,
		SDO_USERNICK_UPDATE =0x0069, 
		SDO_USERNICK_UPDATE_RESP =0x8069, 
		SDO_PADKEYWORD_QUERY = 0x0070,
		SDO_PADKEYWORD_QUERY_RESP = 0x8070,
		SDO_BOARDMESSAGE_REQ = 0x0071,
		SDO_BOARDMESSAGE_REQ_RESP = 0x8071,
		SDO_CHANNELLIST_QUERY =  0x0072,
		SDO_CHANNELLIST_QUERY_RESP = 0x8072,
		SDO_ALIVE_REQ = 0x0073,
		SDO_ALIVE_REQ_RESP = 0x8073,
		SDO_BOARDTASK_QUERY = 0x0074,
		SDO_BOARDTASK_QUERY_RESP = 0x8074,
		SDO_BOARDTASK_UPDATE = 0x0075,
		SDO_BOARDTASK_UPDATE_RESP = 0x8075,
		SDO_BOARDTASK_INSERT = 0x0076,
		SDO_BOARDTASK_INSERT_RESP = 0x8076,
		SDO_DAYSLIMIT_QUERY = 0x0077,
		SDO_DAYSLIMIT_QUERY_RESP = 0x8077,
		SDO_USERLOGIN_DEL = 0x0078,
		SDO_USERLOGIN_DEL_RESP = 0x8078,
		SDO_GATEWAY_QUERY = 0x0079,
		SDO_GATEWAY_QUERY_RESP = 0x8079,
		SDO_USERLOGIN_CLEAR = 0x0080,
		SDO_USERLOGIN_CLEAR_RESP = 0x8080,
		SDO_CHALLENGE_INSERTALL = 0x0081,
		SDO_CHALLENGE_INSERTALL_RESP = 0x8081,
		SDO_USERPASSWD_QUERY  = 0x0082,
		SDO_USERPASSWD_QUERY_RESP  = 0x8082,
		SDO_USERONLINETIME_QUERY  = 0x0083,
		SDO_USERONLINETIME_QUERY_RESP  = 0x8083,
		SDO_YYHAPPYITEM_QUERY = 0x0084,
		SDO_YYHAPPYITEM_QUERY_RESP = 0x8084,
		SDO_YYHAPPYITEM_CREATE = 0x0085,
		SDO_YYHAPPYITEM_CREATE_RESP = 0x8085,
		SDO_YYHAPPYITEM_UPDATE = 0x0086,
		SDO_YYHAPPYITEM_UPDATE_RESP = 0x8086,
		SDO_YYHAPPYITEM_DELETE = 0x0087,
		SDO_YYHAPPYITEM_DELETE_RESP = 0x8087,
		SDO_USER_PUNISH = 0x0088,
		SDO_USER_PUNISH_RESP = 0x8088,		
		SDO_PUNISHUSER_IMPORT_QUERY = 0x0089,
		SDO_PUNISHUSER_IMPORT_QUERY_RESP = 0x8089,
		SDO_PUNISHUSER_IMPORT = 0x0090,
		SDO_PUNISHUSER_IMPORT_RESP = 0x8090,
		SDO_USER_PUNISHALL = 0x0091,
		SDO_USER_PUNISHALL_RESP = 0x8091,
		SDO_FRAGMENT_QUERY = 0x0092,
		SDO_FRAGMENT_QUERY_RESP = 0x8092,
		SDO_FRAGMENT_UPDATE = 0x0093,
		SDO_FRAGMENT_UPDATE_RESP = 0x8093,
		SDO_PFUNCTIONITEM_QUERY = 0x0094,
		SDO_PFUNCTIONITEM_QUERY_RESP = 0x8094,
		SDO_USERMARRIAGE_QUERY = 0x0095,
		SDO_USERMARRIAGEQUERY_RESP = 0x8095,
		SDO_PUNISH_UPDATE_QUERY = 0x0096,
		SDO_PUNISH_UPDATE_QUERY_RESP = 0x8096,
		SDO_REMAINCASH_QUERY = 0x0097,
		SDO_REMAINCASH_QUERY_RESP = 0x8097,
		SDO_PADREGIST_QUERY = 0x0098,
		SDO_PADREGIST_QUERY_RESP = 0x8098,

		SDO_MiniDancerTime_QUERY = 0x0099,
		SDO_MiniDancerTime_QUERY_RESP = 0x8099,
		SDO_RewardItem_QUERY = 0x0100,
		SDO_RewardItem_QUERY_RESP = 0x8100,
		SDO_QueryPunishusertimes_QUERY = 0x0101,
		SDO_QueryPunishusertimes_QUERY_RESP = 0x8101,
		SDO_QueryDeleteItem_QUERY = 0x0102,
		SDO_QueryDeleteItem_QUERY_RESP = 0x8102,
		SDO_NotReachMoney_Query = 0x0103,
		SDO_NotReachMoney_Query_RESP = 0x8103,
		SDO_DoubleMoneyExp_Insert = 0x0104,
		SDO_DoubleMoneyExp_Insert_RESP = 0x8104,
		SDO_DoubleMoneyExp_Query = 0x0105,
		SDO_DoubleMoneyExp_Query_RESP = 0x8105,
		SDO_DoubleMoneyExp_Del = 0x0106,
		SDO_DoubleMoneyExp_Del_RESP = 0x8106,
		SDO_DoubleMoneyExp_Update = 0x0107,
		SDO_DoubleMoneyExp_Update_RESP = 0x8107,
		SDO_UserCheat_Query = 0x0108,
		SDO_UserCheat_Query_RESP = 0x8108,
		SDO_UserCheat_Del = 0x0109,
		SDO_UserCheat_Del_RESP = 0x8109,
		SDO_PetInfo_Query = 0x0110,
		SDO_PetInfo_Query_RESP = 0x8110,
		SDO_StageAward_Query = 0x0111,
		SDO_StageAward_Query_RESP = 0x8111,
		SDO_StageAward_Create = 0x0112,
		SDO_StageAward_Create_RESP = 0x8112,
		SDO_StageAward_Delete = 0x0113,
		SDO_StageAward_Delete_RESP = 0x8113,
		SDO_StageAward_Update = 0x0114,
		SDO_StageAward_Update_RESP = 0x8114,
		SDO_PetDrop_Query = 0x0115,
		SDO_PetDrop_Query_RESP = 0x8115,
		SDO_BatchItemShop_Insert = 0x0116,
		SDO_BatchItemShop_Insert_RESP = 0x8116,
		SDO_UserBugle_Query = 0x0117,
		SDO_UserBugle_Query_RESP = 0x8117,
		SDO_UserMsg_Query = 0x0118,
		SDO_UserMsg_Query_RESP = 0x8118,
		SDO_UserActive_Query = 0x0119,
		SDO_UserActive_Query_RESP = 0x8119,
		SDO_BAOXIANGRate_Query= 0x0120,
		SDO_BAOXIANGRate_Query_RESP= 0x8120,
		SDO_BAOXIANGRate_Update= 0x0121,
		SDO_BAOXIANGRate_Update_RESP= 0x8121,
		SDO_Planet_Query = 0x0122,
		SDO_Planet_Query_RESP = 0x8122,
		SDO_Channel_Query = 0x0123,
		SDO_Channel_Query_RESP = 0x8123,
		SDO_UserOnline_Query = 0x0124,
		SDO_UserOnline_Query_RESP = 0x8124,
		SDO_Family_CONSUME_QUERY = 0x0125,
		SDO_Family_CONSUME_QUERY_RESP = 0x8125,
		SDO_Family_Info_QUERY = 0x0126,//���������Ϣ
		SDO_Family_Info_QUERY_RESP = 0x8126,//���������Ϣ
		SDO_FamilyMember_Query = 0x0127,//�����Ա��Ϣ
		SDO_FamilyMember_Query_RESP = 0x8127,//�����Ա��Ϣ
		SDO_FamilyFormal_Query= 0x0128,//�����г�Ա��Ϣ
		SDO_FamilyFormal_Query_RESP = 0x8128,//�����г�Ա��Ϣ
		SDO_Personal_Emblem_Query = 0x0129,//����ѫ��
		SDO_Personal_Emblem_Query_RESP = 0x8129,//����ѫ��
		SDO_Family_Donate_Query = 0x0130,//�����������ϸ
		SDO_Family_Donate_Query_RESP = 0x8130,//�����������ϸ

		SDO_Family_Delete_Query = 0x0131,//��ɢ����
		SDO_Family_Delete_Query_RESP = 0x8131,//��ɢ����

		SDO_Family_Duty_Query = 0x0132,//�����Աְ���޸�
		SDO_Family_Duty_Query_RESP = 0x8132,//�����Աְ���޸�

		SDO_Family_Emblem_Insert_Query= 0x0133,//�����Ӽ������
		SDO_Family_Emblem_Insert_Query_RESP= 0x8133,//�����Ӽ������

		SDO_Family_Emblem_Delete_Query= 0x0134,//��ɾ���������
		SDO_Family_Emblem_Delete_Query_RESP= 0x8134,//��ɾ���������
		#region �����Ż��ɰ������Ϣ��
		/// <summary>
		/// AU_OLD_ADMIN�����Ż��ɰ������Ϣ��
		/// </summary>
		AU_OLD_CHARACTERINFO_QUERY = 0x0001,//��ѯ��ҵ��˺���Ϣ
		AU_OLD_CHARACTERINFO_QUERY_RESP = 0x8001,//��ѯ��ҵ��˺���Ϣ��Ӧ
		AU_OLD_ITEMSHOP_BYOWNER_QUERY = 0x0002,////�鿴������ϵ�����Ϣ
		AU_OLD_ITEMSHOP_BYOWNER_QUERY_RESP = 0x8002,////�鿴������ϵ�����Ϣ
		AU_OLD_MessageBox_QUERY = 0x0003,//����е���
		AU_OLD_MessageBox_QUERY_RESP = 0x8003,//����е���
		AU_OLD_GOODS_QUERY = 0x0004,//��Ʒ������
		AU_OLD_GOODS_QUERY_RESP = 0x8004,//��Ʒ������
		AU_OLD_CONSUME_QUERY = 0x0005,//�鿴��ҵ����Ѽ�¼
		AU_OLD_CONSUME_QUERY_RESP = 0x8005,//�鿴��ҵ����Ѽ�¼��Ӧ
		AU_OLD_USERCONSUMESUM_QUERY = 0x0006,//�õ����Ѽ�¼�ܺ�
		AU_OLD_USERCONSUMESUM_QUERY_RESP = 0x8006,//�õ����Ѽ�¼�ܺ���Ӧ
		AU_OLD_ITEMSHOP_TRADE_QUERY = 0x0007,//�鿴��ҽ��׼�¼��Ϣ
		AU_OLD_ITEMSHOP_TRADE_QUERY_RESP = 0x8007,//�鿴��ҽ��׼�¼��Ϣ����Ӧ
		AU_OLD_USERCHARAGESUM_QUERY = 0x0008,//�õ���ҽ��׼�¼�ܺ�
		AU_OLD_USERCHARAGESUM_QUERY_RESP = 0x8008,//�õ���ҽ��׼�¼�ܺ���Ӧ
		AU_OLD_COUPLEINFO_QUERY = 0x0009,//��ѯ���������Ϣ
		AU_OLD_COUPLEINFO_QUERY_RESP = 0x8009,//��ѯ���������Ϣ
		AU_OLD_COUPLELOG_QUERY = 0x0010,//��ѯ���������ϢLOG
		AU_OLD_COUPLELOG_QUERY_RESP = 0x8010,//��ѯ���������ϢLOG
		AU_OLD_KickPlayer_Req= 0x0011,//����
		AU_OLD_KickPlayer_Req_RESP = 0x8011,//����
		AU_OLD_BOARDMESSAGE_REQ = 0x0012,
		AU_OLD_BOARDMESSAGE_REQ_RESP = 0x8012,
		AU_OLD_BOARDTASK_INSERT = 0x0013,
		AU_OLD_BOARDTASK_INSERT_RESP = 0x8013,
		AU_OLD_BOARDTASK_QUERY = 0x0014,
		AU_OLD_BOARDTASK_QUERY_RESP = 0x8014,
		AU_OLD_BOARDTASK_UPDATE = 0x0015,
		AU_OLD_BOARDTASK_UPDATE_RESP = 0x8015,
		AU_OLD_GS_QUERY = 0x0016,
		AU_OLD_GS_QUERY_RESP = 0x8016,
		AU_OLD_UserCashPurchase_QUERY = 0x0017,
		AU_OLD_UserCashPurchase_QUERY_RESP = 0x8017,
		#endregion

		/// <summary>
		/// AU_ADMIN �����Ź��߲�����Ϣ��
		/// </summary>
		AU_ACCOUNT_QUERY = 0x0001,//����ʺ���Ϣ��ѯ
		AU_ACCOUNT_QUERY_RESP = 0x8001,//����ʺ���Ϣ��ѯ��Ӧ
		AU_ACCOUNTREMOTE_QUERY = 0x0002,//��Ϸ��������ͣ������ʺŲ�ѯ
		AU_ACCOUNTREMOTE_QUERY_RESP = 0x8002,//��Ϸ��������ͣ������ʺŲ�ѯ��Ӧ
		AU_ACCOUNTLOCAL_QUERY = 0x0003,//���ط�ͣ������ʺŲ�ѯ
		AU_ACCOUNTLOCAL_QUERY_RESP = 0x8003,//���ط�ͣ������ʺŲ�ѯ��Ӧ
		AU_ACCOUNT_CLOSE = 0x0004,//��ͣ������ʺ�
		AU_ACCOUNT_CLOSE_RESP = 0x8004,//��ͣ������ʺ���Ӧ
		AU_ACCOUNT_OPEN = 0x0005,//��������ʺ�
		AU_ACCOUNT_OPEN_RESP = 0x8005,//��������ʺ���Ӧ
		AU_ACCOUNT_BANISHMENT_QUERY = 0x0006,//��ҷ�ͣ�ʺŲ�ѯ
		AU_ACCOUNT_BANISHMENT_QUERY_RESP = 0x8006,//��ҷ�ͣ�ʺŲ�ѯ��Ӧ
		AU_CHARACTERINFO_QUERY = 0x0007,//��ѯ��ҵ��˺���Ϣ
		AU_CHARACTERINFO_QUERY_RESP = 0x8007,//��ѯ��ҵ��˺���Ϣ��Ӧ
		AU_CHARACTERINFO_UPDATE = 0x0008,//�޸���ҵ��˺���Ϣ
		AU_CHARACTERINFO_UPDATE_RESP = 0x8008,//�޸���ҵ��˺���Ϣ��Ӧ
		AU_ITEMSHOP_QUERY = 0x0009,//�鿴��Ϸ�������е�����Ϣ
		AU_ITEMSHOP_QUERY_RESP = 0x8009,//�鿴��Ϸ�������е�����Ϣ��Ӧ
		AU_ITEMSHOP_DELETE = 0x0010,//ɾ����ҵ�����Ϣ
		AU_ITEMSHOP_DELETE_RESP = 0x8010,//ɾ����ҵ�����Ϣ��Ӧ
		AU_ITEMSHOP_BYOWNER_QUERY = 0x0011,////�鿴������ϵ�����Ϣ
		AU_ITEMSHOP_BYOWNER_QUERY_RESP = 0x8011,////�鿴������ϵ�����Ϣ
		AU_ITEMSHOP_TRADE_QUERY = 0x0012,//�鿴��ҽ��׼�¼��Ϣ
		AU_ITEMSHOP_TRADE_QUERY_RESP = 0x8012,//�鿴��ҽ��׼�¼��Ϣ����Ӧ
		AU_ITEMSHOP_CREATE = 0x0013,//�����������е�����Ϣ
		AU_ITEMSHOP_CREATE_RESP = 0x8013,//�����������е�����Ϣ��Ӧ
		AU_LEVELEXP_QUERY = 0x0014,//�鿴��ҵȼ�����
		AU_LEVELEXP_QUERY_RESP = 0x8014,////�鿴��ҵȼ�������Ӧ
		AU_USERLOGIN_STATUS_QUERY = 0x0015,//�鿴��ҵ�¼״̬
		AU_USERLOGIN_STATUS_QUERY_RESP = 0x8015,//�鿴��ҵ�¼״̬��Ӧ
		AU_USERCHARAGESUM_QUERY = 0x0016,//�õ���ֵ��¼�ܺ�
		AU_USERCHARAGESUM_QUERY_RESP = 0x8016,//�õ���ֵ��¼�ܺ���Ӧ
		AU_CONSUME_QUERY = 0x0017,//�鿴��ҵ����Ѽ�¼
		AU_CONSUME_QUERY_RESP = 0x8017,//�鿴��ҵ����Ѽ�¼��Ӧ
		AU_USERCONSUMESUM_QUERY = 0x0018,//�õ����Ѽ�¼�ܺ�
		AU_USERCONSUMESUM_QUERY_RESP = 0x8018,//�õ����Ѽ�¼�ܺ���Ӧ
		AU_USERMCASH_QUERY = 0x0019,//��ҳ�ֵ��¼��ѯ
		AU_USERMCASH_QUERY_RESP = 0x8019,//��ҳ�ֵ��¼��ѯ��Ӧ
		AU_USERGCASH_QUERY = 0x0020,//��ңǱҼ�¼��ѯ
		AU_USERGCASH_QUERY_RESP = 0x8020,//��ңǱҼ�¼��ѯ��Ӧ
		AU_USERGCASH_UPDATE = 0x0021,//�������G��
		AU_USERGCASH_UPDATE_RESP = 0x8021,//�������G�ҵ���Ӧ
		AU_USERNICK_UPDATE = 0x0022,
		AU_USERNICK_UPDATE_RESP = 0x8022,
		AU_MESSENGER_QUERY = 0x0023,
		AU_MESSENGER_QUERY_RESP = 0x8023,
		AU_MESSENGER_UPDATE = 0x0024,
		AU_MESSENGER_UPDATE_RESP = 0x8024,
		AU_WEDDING_QUERY = 0x0025,
		AU_WEDDING_QUERY_RESP = 0x8025,
		AU_WEDDINGGROUND_QUERY = 0x0026,
		AU_WEDDINGGROUND_QUERY_RESP = 0x8026,
		AU_GOODS_QUERY = 0x0027,
		AU_GOODS_QUERY_RESP = 0x8027,
		AU_JOINPCIP_QUERY = 0x0028,
		AU_JOINPCIP_QUERY_RESP = 0x8028,
		AU_JOINPCIP_Insert = 0x0029,
		AU_JOINCPIP_Insert_RESP =  0x8029,
		AU_JOINPCIP_Delete = 0x0030,
		AU_JOINPCIP_Delete_RESP = 0x8030,
		AU_MEMBERACTIVE_CREATE = 0x0031,
		AU_MEMBERACTIVE_CREATE_RESP = 0x8031,
		AU_BOARDMESSAGE_REQ = 0x0032,
		AU_BOARDMESSAGE_REQ_RESP = 0x8032,
		AU_BOARDTASK_INSERT = 0x0033,
		AU_BOARDTASK_INSERT_RESP = 0x8033,
		AU_BOARDTASK_QUERY = 0x0034,
		AU_BOARDTASK_QUERY_RESP = 0x8034,
		AU_BOARDTASK_UPDATE = 0x0035,
		AU_BOARDTASK_UPDATE_RESP = 0x8035,
		AU_GS_QUERY = 0x0036,
		AU_GS_QUERY_RESP = 0x8036,
		AU_EXCEPTLEVEL_UPDATE = 0x0037,
		AU_EXCEPTLEVEL_UPDATE_RESP = 0x8037,
		AU_WEDDINGINFO_QUERY = 0x0038,
		AU_WEDDINGINFO_QUERY_RESP = 0x8038,
		AU_WEDDINGLOG_QUERY = 0x0039,
		AU_WEDDINGLOG_QUERY_RESP = 0x8039,
		AU_COUPLEINFO_QUERY = 0x0040,
		AU_COUPLEINFO_QUERY_RESP = 0x8040,
		AU_COUPLELOG_QUERY = 0x0041,
		AU_COUPLELOG_QUERY_RESP = 0x8041,
		AU_LEVELEXP_OWNER_QUERY = 0x0042,
		AU_LEVELEXP_OWNER_QUERY_RESP = 0x8042,
		AU_MessageBox_QUERY = 0x0043,
		AU_MessageBox_QUERY_RESP = 0x8043,
		AU_BATTLEPARTY_UPDATE = 0x0044,
		AU_BATTLEPARTY_UPDATE_RESP = 0x8044,
		AU_lovepartyround_Query = 0x0045,
		AU_lovepartyround_Query_RESP = 0x8045,
		Audition_PlayerFam_Query= 0x0046,
		Audition_PlayerFam_Query_RESP = 0x8046,
		Audition_Faminfo_Query= 0x0047,
		Audition_Faminfo_Query_RESP = 0x8047,
		Audition_FamIteminfo_Query= 0x0048,
		Audition_FamIteminfo_Query_RESP = 0x8048,
		Audition_FamMember_Query= 0x0049,
		Audition_FamMember_Query_RESP = 0x8049,
		Audition_Updategradename_Query= 0x0050,
		Audition_Updategradename_Query_RESP = 0x8050,
		Au_FamItembuylog_Query= 0x0051,
		Au_FamItembuylog_Query_RESP = 0x8051,
		AU_KickPlayer_Req= 0x0052,
		AU_KickPlayer_Req_RESP = 0x8052,
		AU_ChannelList_Query=0x0053,//����Ƶ���б�
		AU_ChannelList_Query_RESP = 0x8053,//����Ƶ���б�
		AU_UserRoomPlayer_Query=0x0054,//���󷿼��û���Ϣ
		AU_UserRoomPlayer_Query_RESP = 0x8054,//���󷿼��û���Ϣ
		AU_KickRoom_Req= 0x0055,//�߷��书��
		AU_KickRoom_Req_RESP = 0x8055,//�߷��书��
		AU_RoomList_Query=0x0056,//���󷿼���б�
		AU_RoomList_Query_RESP = 0x8056,//���󷿼���б�
		Au_Broaditeminfo_Query=0x0057,//�û�����������־
		Au_Broaditeminfo_Query_Resp=0x8057,//�û�����������־
		Au_Famuserlog_Query=0x0058,//����ת�ü�¼
		Au_Famuserlog_Query_Resp=0x8058,//����ת�ü�¼
		Au_BroaditeminfoNow_Query=0x0059,//��ǰʱ���û�����������־
		Au_BroaditeminfoNow_Query_Resp=0x8059,//��ǰʱ���û�����������־
		Au_BroaditeminfoBymsg_Query=0x0060,//����ģ����ѯ�û�����������־
		Au_BroaditeminfoBymsg_Query_Resp=0x8060,//����ģ����ѯ�û�����������־
		Au_User_Active_Query=0x0061,	//��ѯ�������Ϸ�����ڵĴ�����Ƶ��������
		Au_User_Active_Query_Resp=0x8061,	//��ѯ�������Ϸ�����ڵĴ�����Ƶ��������
		Au_User_Msg_Query = 0x0062,		//��ѯ�������Ϸ�е������¼	
		Au_User_Msg_Query_Resp = 0x8062,//��ѯ�������Ϸ�е������¼
		Au_Send_Msg_Query = 0x0063,//�����û�
		Au_Send_Msg_Query_Resp = 0x8063,//�����û�
		Au_User_All_Query = 0x0064,//Ƶ���������û�
		Au_User_All_Query_Resp = 0x8064,//Ƶ���������û�
		AU_UserNameByID_Query= 0x0065,
		AU_UserNameByID_Query_RESP = 0x8065,
		AU_KickPlayerandBan_Req= 0x0066,
		AU_KickPlayerandBan_Req_RESP = 0x8066,
		AU_NicknameAndUnBan_Update= 0x0068,
		AU_NicknameAndUnBan_Update_RESP = 0x8068,
		AU_UserLinkStat_Query= 0x0067,
		AU_UserLinkStat_Query_RESP = 0x8067,

		/// <summary>
		/// CR_ADMIN ��񿨶������߲�����Ϣ��
		/// </summary>
		CR_ACCOUNT_QUERY = 0x0001,//����ʺ���Ϣ��ѯ
		CR_ACCOUNT_QUERY_RESP = 0x8001,//����ʺ���Ϣ��ѯ��Ӧ
		CR_ACCOUNTACTIVE_QUERY = 0x0002,//����ʺż�����Ϣ
		CR_ACCOUNTACTIVE_QUERY_RESP = 0x8002,//����ʺż�����Ӧ
		CR_CALLBOARD_QUERY = 0x0003,//������Ϣ��ѯ
		CR_CALLBOARD_QUERY_RESP = 0x8003,//������Ϣ��ѯ��Ӧ
		CR_CALLBOARD_CREATE = 0x0004,//��������
		CR_CALLBOARD_CREATE_RESP = 0x8004,//����������Ӧ
		CR_CALLBOARD_UPDATE = 0x0005,//���¹�����Ϣ
		CR_CALLBOARD_UPDATE_RESP = 0x8005,//���¹�����Ϣ����Ӧ
		CR_CALLBOARD_DELETE = 0x0006,//ɾ��������Ϣ
		CR_CALLBOARD_DELETE_RESP = 0x8006,//ɾ��������Ϣ����Ӧ
		CR_CHARACTERINFO_QUERY = 0x0007,//��ҽ�ɫ��Ϣ��ѯ
		CR_CHARACTERINFO_QUERY_RESP = 0x8007,//��ҽ�ɫ��Ϣ��ѯ����Ӧ
		CR_CHARACTERINFO_UPDATE = 0x0008,//��ҽ�ɫ��Ϣ��ѯ
		CR_CHARACTERINFO_UPDATE_RESP = 0x8008,//��ҽ�ɫ��Ϣ��ѯ����Ӧ
		CR_CHANNEL_QUERY = 0x0009,//����Ƶ����ѯ
		CR_CHANNEL_QUERY_RESP = 0x8009,//����Ƶ����ѯ����Ӧ
		CR_NICKNAME_QUERY = 0x0010,//����ǳƲ�ѯ
		CR_NICKNAME_QUERY_RESP = 0x8010,//����ǳƵ���Ӧ
		CR_LOGIN_LOGOUT_QUERY = 0x0011,//������ߡ�����ʱ���ѯ
		CR_LOGIN_LOGOUT_QUERY_RESP = 0x8011,//������ߡ�����ʱ���ѯ����Ӧ
		CR_ERRORCHANNEL_QUERY = 0x0012,//������󹫸�Ƶ����ѯ
		CR_ERRORCHANNEL_QUERY_RESP = 0x8012,//������󹫸�Ƶ����ѯ����Ӧ

		/// <summary>
		/// ��ֵ����GM����(0x90)
		/// </summary>
		CARD_USERCHARGEDETAIL_QUERY = 0x0001,//һ��ͨ��ѯ
		CARD_USERCHARGEDETAIL_QUERY_RESP = 0x8001,//һ��ͨ��ѯ��Ӧ
		CARD_USERDETAIL_QUERY = 0x0002,//��֮���û�ע����Ϣ��ѯ
		CARD_USERDETAIL_QUERY_RESP = 0x8002,//��֮���û�ע����Ϣ��ѯ��Ӧ
		CARD_USERCONSUME_QUERY = 0x0003,//���б����Ѳ�ѯ
		CARD_USERCONSUME_QUERY_RESP = 0x8003,//���б����Ѳ�ѯ��Ӧ
		CARD_VNETCHARGE_QUERY = 0x0004,//�����ǿճ�ֵ��ѯ
		CARD_VNETCHARGE_QUERY_RESP = 0x8004,//�����ǿճ�ֵ��ѯ��Ӧ
		CARD_USERDETAIL_SUM_QUERY = 0x0005,//��ֵ�ϼƲ�ѯ
		CARD_USERDETAIL_SUM_QUERY_RESP = 0x8005,//��ֵ�ϼƲ�ѯ��Ӧ
		CARD_USERCONSUME_SUM_QUERY = 0x0006,//���ѺϼƲ�ѯ
		CARD_USERCONSUME_SUM_QUERY_RESP = 0x8006,//���Ѻϼ���Ӧ
		CARD_USERINFO_QUERY = 0x0007,//���ע����Ϣ��ѯ
		CARD_USERINFO_QUERY_RESP = 0x8007,//���ע����Ϣ��ѯ��Ӧ
		CARD_USERINFO_CLEAR = 0x0008,
		CARD_USERINFO_CLEAR_RESP = 0x8008,
		CARD_USERSECURE_CLEAR = 0x0009,//������Ұ�ȫ����Ϣ
		CARD_USERSECURE_CLEAR_RESP = 0x8009,//������Ұ�ȫ����Ϣ��Ӧ
		CARD_USERNICK_QUERY = 0x0010,
		CARD_USERNICK_QUERY_RESP = 0x8010,
		CARD_USERLOCK_UPDATE = 0x0011,
		CARD_USERLOCK_UPDATE_RESP = 0x8011,
		CARD_BALANCE_QUERY = 0x0012,
		CARD_BALANCE_QUERY_RESP = 0x8012,
		CARD_USERNUM_QUERY = 0x0013,
		CARD_USERNUM_QUERY_RESP = 0x8013,
		CARD_USERHISTORYPWD_QUERY = 0x0014,
		CARD_USERHISTORYPWD_QUERY_RESP = 0x8014,
		CARD_USERINITACTIVE_QUERY = 0x0015,
		CARD_USERINITACTIVE_QUERY_RESP = 0x8015,
		TOKEN_TOKENSTATUS_QUERY = 0x0016,//��ʾ���Ƶĵ�ǰ״̬
		TOKEN_TOKENSTATUS_QUERY_RESP = 0x8016,
		TOKEN_MODIFYUSER_QUERY = 0x0017,//�û������޸�
		TOKEN_MODIFYUSER_QUERY_RESP = 0x8017,
		CARD_USER_QUERY = 0x0018,
		CARD_USER_QUERY_RESP =  0x8018,
		CARD_USERLOCK_QUERY = 0x0019,
		CARD_USERLOCK_QUERY_RESP = 0x8019,
		CARD_USERCARDLOCK_QUERY = 0x0020,
		CARD_USERCARDLOCK_QUERY_RESP = 0x8020,
		CARD_USERTOKEN_QUERY = 0x0021,
		CARD_USERTOKEN_QUERY_RESP = 0x8021,
		CARD_USERTOKEN_OPEN = 0x0022,
		CARD_USERTOKEN_OPEN_RESP = 0x8022,
		CARD_USERTOKEN_CLOSE = 0x0023,
		CARD_USERTOKEN_CLOSE_RESP = 0x8023,
		CARD_USERTOKEN_RELEASE = 0x0024,
		CARD_USERTOKEN_RELEASE_RESP = 0x8024,
		CARD_UserCashExp_Query = 0x0025,
		CARD_UserCashExp_Query_RESP = 0x8025,
		CARD_QueryUseDetailExp_Query = 0x0026,
		CARD_QueryUseDetailExp_RESP = 0x8026,
		CARD_USERNUM_ADVANCE_QUERY = 0x0027,
		CARD_USERNUM_ADVANCE_QUERY_RESP = 0x8027,
		CARD_MOBILEINFO_QUERY = 0x0028,
		CARD_MOBILEINFO_QUERY_RESP = 0x8028,
		CARD_TOKENPASSWD_SYNC = 0x0029,
		CARD_TOKENPASSWD_SYNC_RESP = 0x8029,
		CARD_MOBILEINFO_UPDATE = 0x0030,
		CARD_MOBILEINFO_UPDATE_RESP = 0x8030,
		CARD_USERCARDHISTORY_QUERY = 0x0031,
		CARD_USERCARDHISTORY_QUERY_RESP = 0x8031,
		CARD_DanceItem_QUERY = 0x0032,
		CARD_DanceItem_QUERY_RESP = 0x8032,
		CARD_RESETHISTORY_QUERY = 0x0033,
		CARD_RESETHISTORY_QUERY_RESP = 0x8033,
		CARD_DanceItem_Qualification_QUERY = 0x0034,
		CARD_DanceItem_Qualification_QUERY_RESP = 0x8034,
		CARD_USERACTIVETOKEN_QUERY = 0x0035,
		CARD_USERACTIVETOKEN_QUERY_RESP = 0x8035,
		CARD_USERFCMSTATE_QUERY = 0x0036,
		CARD_USERFCMSTATE_QUERY_RESP = 0x8036,
		CARD_USERFCMSTATE_ACTIVE = 0x0037,
		CARD_USERFCMSTATE_ACTIVE_RESP = 0x8037,
		CARD_AUZONE_QUERY = 0x0038,
		CARD_AUZONE_QUERY_RESP = 0x8038,
		CARD_USERVALID_QUERY = 0x0039,
		CARD_USERVALID_QUERY_RESP = 0x8039,
		CARD_USERYOU9VALID_QUERY = 0x0040,
		CARD_USERYOU9VALID_QUERY_RESP = 0x8040,
		CARD_USERQUESTION_QUERY = 0x0041,
		CARD_USERQUESTION_QUERY_RESP = 0x8041,
		CARD_CheckPayFeeSum = 0x0042,
		CARD_CheckPayFeeSum_Resp = 0x8042,
		CARD_AwardCoinLog_Query = 0x0043,
		CARD_AwardCoinLog_Query_Resp = 0x8043,
		CARD_CardAwardInfo_Query = 0x0044,
		CARD_CardAwardInfo_Query_Resp = 0x8044,
		CARD_CreditCardReward_Query = 0x0045,
		CARD_CreditCardReward_Query_Resp = 0x8045,
		CARD_QueryNickChange_Query = 0x0046,
		CARD_QueryNickChange_Query_Resp = 0x8046,
		CARD_Querymatrixcardinfo_Query = 0x0047,
		CARD_Querymatrixcardinfo_Query_Resp = 0x8047,
		CARD_QueryUserType_Query = 0x0048,
		CARD_QueryUserType_Query_Resp = 0x8048,
		CARD_userpackage_Query=0x0049,
		CARD_userpackage_Query_Resp=0x8049,
		CARD_transaction_Query= 0x0050,
		CARD_transaction_Query_Resp= 0x8050,
		CARD_userpoints_Query= 0x0051,
		CARD_userpoints_Query_Resp= 0x8051,
		CARD_pointsdetail_Query= 0x0052,
		CARD_pointsdetail_Query_Resp= 0x8052,
		CARD_Userinfo_Query= 0x0053,
		CARD_Userinfo_Query_Resp= 0x8053,
		CARD_SamsongSn_Query= 0x0054,
		CARD_SamsongSn_Query_Resp= 0x8054,
		CARD_9youmatrixcard_disable= 0x0055,
		CARD_9youmatrixcard_disable_Resp= 0x8055,
		CARD_9youExchageIDCard_Query = 0x0056,	//15λת18λ����֤
		CARD_9youExchageIDCard_Query_Resp = 0x8056,//15λת18λ����֤
		CARD_NetBarInfo_Query = 0x0057,	//������Ϣ��ѯ
		CARD_NetBarInfo_Query_Resp = 0x8057,//������Ϣ��ѯ
		CARD_NBDetailInfo_Query = 0x0058,	//������ϸ��Ϣ��ѯ
		CARD_NBDetailInfo_Query_Resp = 0x8058,//������ϸ��Ϣ��ѯ
		CARD_NBOperAccount_Query = 0x0059,	//���ɲ����ʺ�
		CARD_NBOperAccount_Query_Resp = 0x8059,//���ɲ����ʺ�
		CARD_NBLevelInfo_Query = 0x0060,	//���ɵȼ���Ϣ��ѯ
		CARD_NBLevelInfo_Query_Resp = 0x8060,//���ɵȼ���Ϣ��ѯ
		CARD_NBPointInfo_Query = 0x0061,	//���ɻ�����Ϣ��ѯ
		CARD_NBPointInfo_Query_Resp = 0x8061,//���ɻ�����Ϣ��ѯ
		CARD_NBOfficialAct_Query = 0x0062,	//���ɹٷ����Ϣ��ѯ
		CARD_NBOfficialAct_Query_Resp = 0x8062,//���ɹٷ����Ϣ��ѯ
		CARD_NBSpontAct_Query = 0x0063,	//�����Է����Ϣ��ѯ
		CARD_NBSpontAct_Query_Resp = 0x8063,//�����Է����Ϣ��ѯ
		CARD_NBPointExchange_Query = 0x0064,	//���ɻ��ֶһ���¼
		CARD_NBPointExchange_Query_Resp = 0x8064,//���ɻ��ֶһ���¼
		CARD_NBAccountLogin_Query = 0x0065,	//�����ʺŵ�½��־��ѯ
		CARD_NBAccountLogin_Query_Resp = 0x8065,//�����ʺŵ�½��־��ѯ
		CARD_NBEditPoint_Query = 0x0066,	//�����޸�
		CARD_NBEditPoint_Query_Resp = 0x8066,//�����޸�
		CARD_NBEditLevel_Query = 0x0067,	//�ȼ��޸�
		CARD_NBEditLevel_Query_Resp = 0x8067,//�ȼ��޸�
		CARD_NBEditStates_Query = 0x0068,	//�������
		CARD_NBEditStates_Query_Resp = 0x8068,//�������

		/// <summary>
		/// �������̳�(0x91)
		/// </summary>
		AUSHOP_USERGPURCHASE_QUERY = 0x0001,//�û�G�ҹ����¼
		AUSHOP_USERGPURCHASE_QUERY_RESP = 0x8001,//�û�G�ҹ����¼
		AUSHOP_USERMPURCHASE_QUERY = 0x0002,//�û�M�ҹ����¼
		AUSHOP_USERMPURCHASE_QUERY_RESP = 0x8002,//�û�M�ҹ����¼
		AUSHOP_AVATARECOVER_QUERY = 0x0003,//���߻��նһ���
		AUSHOP_AVATARECOVER_QUERY_RESP = 0x8003,//���߻��նһ���
		AUSHOP_USERINTERGRAL_QUERY = 0x0004,//�û����ּ�¼
		AUSHOP_USERINTERGRAL_QUERY_RESP = 0x8004,//�û����ּ�¼
		AUSHOP_USEROPERLOG_CREATE = 0x0005,//�������̳� - �˿��
		AUSHOP_USEROPERLOG_CREATE_RESP = 0x8005,//�������̳� - �˿��
		AUSHOP_USERMPURCHASE_SUM_QUERY = 0x0006,//�û�M�ҹ����¼�ϼ�
		AUSHOP_USERMPURCHASE_SUM_QUERY_RESP = 0x8006,//�û�M�ҹ����¼�ϼ���Ӧ
		AUSHOP_AVATARECOVER_DETAIL_QUERY = 0x0007,//���߻��նһ���ϸ��¼
		AUSHOP_AVATARECOVER_DETAIL_QUERY_RESP = 0x8007,//���߻��նһ���ϸ��¼
		AUSHOP_WAREHOUSE_QUERY = 0x0008,
		AUSHOP_WAREHOUSE_QUERY_RESP = 0x8008,
		AUSHOP_ERRBUY_REFUND = 0x0009,//�������̳� - �������˿� 
		AUSHOP_ERRBUY_REFUND_RESP = 0x8009,//�������̳� - �������˿� 
		AUSHOP_REPEATBuy_REFUND = 0x0010,//�������̳� - �ظ������˿� 
		AUSHOP_REPEATBuy_REFUND_RESP = 0x8010,//�������̳� - �ظ������˿� 
		AUSHOP_FillBuy_REFUND = 0x0011,//�������̳� - ����
		AUSHOP_FillBuy_REFUND_RESP = 0x8011,//�������̳� - ����
		AUSHOP_REPEATGet_REFUND = 0x0012,
		AUSHOP_REPEATGet_REFUND_RESP = 0x8012,
		AUSHOP_SPECIALAVATITEM_QUERY  = 0x0013,//С����
		AUSHOP_SPECIALAVATITEM_QUERY_RESP  = 0x8013,//С����
		AUSHOP_OTHERSPECIALAVATITEM_QUERY  = 0x0014,//�������������
		AUSHOP_OTHERSPECIALAVATITEM_QUERY_RESP  = 0x8014,//�������������
		AUSHOP_Supply_Process  = 0x0015,//�����������
		AUSHOP_Supply_Process_RESP  = 0x8015,//�����������
		AUSHOP_SupplyAgain_A_Process  = 0x0016,//�����������A
		AUSHOP_SupplyAgain_A_Process_RESP  = 0x8016,//�����������A
		AUSHOP_SupplyAgain_B_Process  = 0x0017,//�����������B
		AUSHOP_SupplyAgain_B_Process_RESP  = 0x8017,//�����������B
		AUSHOP_SupplyAgain_C_Process  = 0x0018,//�����������B
		AUSHOP_SupplyAgain_C_Process_RESP  = 0x8018,//�����������B
		AUSHOP_SupplyAgain_Immediacy_A_Process  = 0x0019,//ֱ��д���û�avatar_inventory_xxx����A
		AUSHOP_SupplyAgain_Immediacy_A_Process_RESP  = 0x8019,//ֱ��д���û�avatar_inventory_xxx����A
		AUSHOP_SupplyAgain_Immediacy_B_Process  = 0x0020,//�����������B
		AUSHOP_SupplyAgain_Immediacy_B_Process_RESP  = 0x8020,//�����������B
		AUSHOP_ERRORZONE_REFUND  = 0x0021,//�û������������
		AUSHOP_ERRORZONE_REFUND_RESP  = 0x8021,//�û������������
		AUSHOP_QueryAup  = 0x0022,
		AUSHOP_QueryAup_RESP  = 0x8022,
		AUSHOP_RECVITEM_QUERY  = 0x0023,//�������̳� - ��ѯ�û��Ѷһ���¼
		AUSHOP_RECVITEM_QUERY_RESP  = 0x8023,
		AUSHOP_RECVPOOL_QUERY  = 0x0024,//ȡ���ջ�����б�
		AUSHOP_RECVPOOL_QUER_RESP  = 0x8024,//ȡ���ջ�����б�	
		AUSHOP_SupplyAgain_Immediacy_C_Process  = 0x0025,//�����������C
		AUSHOP_SupplyAgain_Immediacy_C_Process_RESP  = 0x8025,//�����������C
		AuShop_UpdateUserConsumeLevel_Query = 0x0026,
		AuShop_UpdateUserConsumeLevel_Query_Resp = 0x8026,

		AuShop_SearchUserConsumeLevel_Query = 0x0027,
		AuShop_SearchUserConsumeLevel_Query_Resp = 0x8027,

		AuShop_ShowUserVipLevel_Query = 0x0028,
		AuShop_ShowUserVipLevel_Query_Resp = 0x8028,
		AU_VipUser_Query = 0x0029,//�Ƿ���VIP�û�
		AU_VipUser_Query_Resp = 0x8029,//�Ƿ���VIP�û�
		AU_GetErrNotice_Query = 0x0030,//���ʧ�ܹ���
		AU_GetErrNotice_Query_Resp = 0x8030,//���ʧ�ܹ���
		AU_UpdateErrNotice_Query = 0x0031,//���ʧ�ܹ���
		AU_UpdateErrNotice_Query_Resp = 0x8031,//���ʧ�ܹ���

		/// <summary>
		/// �����Ź���(0x92)
		/// </summary>
		O2JAM_CHARACTERINFO_QUERY= 0x0001,//��ҽ�ɫ��Ϣ��ѯ
		O2JAM_CHARACTERINFO_QUERY_RESP= 0x8001,//��ҽ�ɫ��Ϣ��ѯ
		O2JAM_CHARACTERINFO_UPDATE= 0x0002,//��ҽ�ɫ��Ϣ����
		O2JAM_CHARACTERINFO_UPDATE_RESP= 0x8002,//��ҽ�ɫ��Ϣ����
		O2JAM_ITEM_QUERY= 0x0003,//��ҵ�����Ϣ��ѯ
		O2JAM_ITEM_QUERY_RESP= 0x8003,//��ҽ�ɫ��Ϣ��ѯ
		O2JAM_ITEM_UPDATE= 0x0004,//��ҵ�����Ϣ����
		O2JAM_ITEM_UPDATE_RESP= 0x8004,//��ҵ�����Ϣ����
		O2JAM_CONSUME_QUERY= 0x0005,//���������Ϣ��ѯ
		O2JAM_CONSUME_QUERY_RESP= 0x8005,//���������Ϣ��ѯ
		O2JAM_ITEMDATA_QUERY= 0x0006,//�����б���ѯ
		O2JAM_ITEMDATA_QUERY_RESP= 0x8006,//�����б���Ϣ��ѯ
		O2JAM_GIFTBOX_QUERY = 0x0007,//�������в�ѯ
		O2JAM_GIFTBOX_QUERY_RESP = 0x8007,//�������в�ѯ
		O2JAM_USERGCASH_UPDATE = 0x0008,//�������G��
		O2JAM_USERGCASH_UPDATE_RESP = 0x8008,//�������G�ҵ���Ӧ
		O2JAM_CONSUME_SUM_QUERY= 0x0009,//���������Ϣ��ѯ
		O2JAM_CONSUME_SUM_QUERY_RESP= 0x8009,//���������Ϣ��ѯ
		O2JAM_GIFTBOX_CREATE= 0x0010,//�����������е���
		O2JAM_GIFTBOX_CREATE_RESP= 0x8010,//�����������е���
		O2JAM_ITEMNAME_QUERY = 0x0011,
		O2JAM_ITEMNAME_QUERY_RESP = 0x8011,
		O2JAM_GIFTBOX_DELETE = 0x0012,
		O2JAM_GIFTBOX_DELETE_RESP  =0x8012,
		O2JAM_USERLOGIN_DEL = 0x0013,
		O2JAM_USERLOGIN_DEL_RESP = 0x8013,

		O2JAM_BOARDMESSAGE_REQ = 0x0014,
		O2JAM_BOARDMESSAGE_REQ_RESP = 0x8014,
		O2JAM_BOARDTASK_INSERT = 0x0015,
		O2JAM_BOARDTASK_INSERT_RESP = 0x8015,
		O2JAM_BOARDTASK_QUERY = 0x0016,
		O2JAM_BOARDTASK_QUERY_RESP = 0x8016,
		O2JAM_BOARDTASK_UPDATE = 0x0017,
		O2JAM_BOARDTASK_UPDATE_RESP = 0x8017,
		O2JAM_GS_QUERY = 0x0018,
		O2JAM_GS_QUERY_RESP = 0x8018,

		/// <summary>
		/// ������IIGM����(0x93)
		/// </summary>
		O2JAM2_ACCOUNT_QUERY = 0x0001,//����ʺ���Ϣ��ѯ
		O2JAM2_ACCOUNT_QUERY_RESP = 0x8001,//����ʺ���Ϣ��ѯ��Ӧ
		O2JAM2_ACCOUNTACTIVE_QUERY = 0x0002,//����ʺż�����Ϣ
		O2JAM2_ACCOUNTACTIVE_QUERY_RESP = 0x8002,//����ʺż�����Ӧ
		O2JAM2_CHARACTERINFO_QUERY = 0x0003,//�û���Ϣ��ѯ
		O2JAM2_CHARACTERINFO_QUERY_RESP = 0x8003,
		O2JAM2_CHARACTERINFO_UPDATE = 0x0004,//�û���Ϣ�޸�
		O2JAM2_CHARACTERINFO_UPDATE_RESP = 0x8004,
		O2JAM2_ITEMSHOP_QUERY = 0x0005,
		O2JAM2_ITEMSHOP_QUERY_RESP = 0x8005,
		O2JAM2_ITEMSHOP_DELETE = 0x0006,
		O2JAM2_ITEMSHOP_DELETE_RESP = 0x8006,
		O2JAM2_MESSAGE_QUERY = 0x0007,
		O2JAM2_MESSAGE_QUERY_RESP = 0x8007,
		O2JAM2_MESSAGE_CREATE = 0x0008,
		O2JAM2_MESSAGE_CREATE_RESP = 0x8008,
		O2JAM2_MESSAGE_DELETE = 0x0009,
		O2JAM2_MESSAGE_DELETE_RESP = 0x8009,
		O2JAM2_CONSUME_QUERY = 0x0010,
		O2JAM2_CONUMSE_QUERY_RESP = 0x8010,
		O2JAM2_CONSUME_SUM_QUERY = 0x0011,
		O2JAM2_CONUMSE_QUERY_SUM_RESP = 0x8011,
		O2JAM2_TRADE_QUERY = 0x0012,
		O2JAM2_TRADE_QUERY_RESP = 0x8012,
		O2JAM2_TRADE_SUM_QUERY = 0x0013,
		O2JAM2_TRADE_QUERY_SUM_RESP = 0x8013,
		O2JAM2_AVATORLIST_QUERY = 0x0014,
		O2JAM2_AVATORLIST_QUERY_RESP = 0x8014,
		O2JAM2_ACCOUNT_CLOSE = 0x0015,//��ͣ�ʻ���Ȩ����Ϣ
		O2JAM2_ACCOUNT_CLOSE_RESP = 0x8015,//��ͣ�ʻ���Ȩ����Ϣ��Ӧ
		O2JAM2_ACCOUNT_OPEN = 0x0016,//����ʻ���Ȩ����Ϣ
		O2JAM2_ACCOUNT_OPEN_RESP = 0x8016,//����ʻ���Ȩ����Ϣ��Ӧ
		O2JAM2_MEMBERBANISHMENT_QUERY = 0x0017,
		O2JAM2_MEMBERBANISHMENT_QUERY_RESP = 0x8017,
		O2JAM2_MEMBERSTOPSTATUS_QUERY = 0x0018,
		O2JAM2_MEMBERSTOPSTATUS_QUERY_RESP = 0x8018,
		O2JAM2_MEMBERLOCAL_BANISHMENT = 0x0019,
		O2JAM2_MEMBERLOCAL_BANISHMENT_RESP = 0x8019,
		O2JAM2_USERLOGIN_DELETE = 0x0020,
		O2JAM2_USERLOGIN_DELETE_RESP = 0x8020,
		O2JAM2_LEVELEXP_QUERY = 0x0021,
		O2JAM2_LEVELEXP_QUERY_RESP =  0x8021,

		/// <summary>
		/// �������� Add by KeHuaQing 2006-09-14
		/// </summary>
		SOCCER_CHARACTERINFO_QUERY = 0x0001,//�û���Ϣ��ѯ
		SOCCER_CHARACTERINFO_QUERY_RESP = 0x8001,
		SOCCER_CHARCHECK_QUERY = 0x0002,//�û�NameCheck,SocketCheck
		SOCCER_CHARCHECK_QUERY_RESP = 0x8002,
		SOCCER_CHARITEMS_RECOVERY_QUERY = 0x0003,//�û�����
		SOCCER_CHARITEMS_RECOVERY_QUERY_RESP = 0x8003,
		SOCCER_CHARPOINT_QUERY = 0x0004,//�û�G���޸�
		SOCCER_CHARPOINT_QUERY_RESP = 0x8004,
		SOCCER_DELETEDCHARACTERINFO_QUERY = 0x0005,//ɾ���û���ѯ
		SOCCER_DELETEDCHARACTERINFO_QUERY_RESP = 0x8005,
		SOCCER_CHARACTERSTATE_MODIFY = 0x0006,//ͣ���ɫ
		SOCCER_CHARACTERSTATE_MODIFY_RESP = 0x8006,
		SOCCER_ACCOUNTSTATE_MODIFY = 0x0007,//ͣ�����
		SOCCER_ACCOUNTSTATE_MODIFY_RESP = 0x8007,
		SOCCER_CHARACTERSTATE_QUERY = 0x0008,//ͣ���ɫ��ѯ
		SOCCER_CHARACTERSTATE_QUERY_RESP = 0x8008,
		SOCCER_ACCOUNTSTATE_QUERY = 0x0009,//ͣ����Ҳ�ѯ
		SOCCER_ACCOUNTSTATE_QUERY_RESP = 0x8009,
		SOCCER_ACCOUNTACTIVE_QUERY = 0x0010,//��Ҽ����ѯ
		SOCCER_ACCOUNTACTIVE_QUERY_RESP = 0x8010,
		SOCCER_USERTRADE_QUERY = 0x0011,//��ҵ��߹����¼�����ͼ�¼
		SOCCER_USERTRADE_QUERY_RESP = 0x8011,
		SOCCER_ITEM_SKILL_MODIFY = 0x0012,//ɾ����ɫ���ߡ�����
		SOCCER_ITEM_SKILL_MODIFY_RESP = 0x8012,//ɾ����ɫ���ߡ�����
		SOCCER_ACCOUNT_ITEMSKILL_QUERY = 0x0013,//������ϵĵ��ߡ�����
		SOCCER_ACCOUNT_ITEMSKILL_QUER_RESPY = 0x8013,//������ϵĵ��ߡ�����
		SOCCER_CHARINFO_MODIFY = 0x0014,//��ҽ�ɫ��Ϣ�޸�
		SOCCER_CHARINFO_MODIFY_RESPY = 0x8014,//��ҽ�ɫ��Ϣ�޸�
		SOCCER_ITEMSHOP_INSERT = 0x0015,//��������͵���
		SOCCER_ITEMSHOP_INSERT_RESPY = 0x8015,//��������͵���
		SOCCER_ITEM_SKILL_QUERY = 0x0016,//��ý�ɫ���ߡ�����
		SOCCER_ITEM_SKILL_QUERY_RESP = 0x8016,//��ý�ɫ���ߡ�����
		SOCCER_ITEM_SKILL_BLUR_QUERY = 0x0017,//��ý�ɫ���ߡ�����
		SOCCER_ITEM_SKILL_BLUR_QUERY_RESP = 0x8017,//��ý�ɫ���ߡ�����
		/// <summary>
		/// ���֮��
		/// </summary>
		FJ_CharacterInfo_Query = 0x0001,
		FJ_CharacterInfo_Query_Resp = 0x8001,
		FJ_ItemShop_Query = 0x0002,
		FJ_ItemShop_Query_Resp = 0x8002,
		FJ_Message_Query = 0x0003,
		FJ_Message_Query_Resp = 0x8003,
		FJ_WareHouse_Query = 0x0004,
		FJ_WareHouse_Query_Resp = 0x8004,
		FJ_Login_Query = 0x0005,
		FJ_Login_Query_Resp = 0x8005,
		FJ_Login_Out_Update = 0x0006,
		FJ_Login_Out_Update_Resp = 0x8006,
		FJ_PlayPosition_Query = 0x0007,
		FJ_PlayPosition_Query_Resp = 0x8007,
		FJ_AccountActive_Query = 0x0009,
		FJ_AccountActive_Query_Resp  = 0x8009,
		FJ_ActiveCode_Query = 0x0010,
		FJ_ActiveCode_Query_Resp  = 0x8010,
		FJ_ItemShop_Insert = 0x0011,
		FJ_ItemShop_Insert_Resp = 0x8011,
		FJ_Wedding_Query = 0x0012,
		FJ_Wedding_Query_Resp = 0x8012,
		FJ_Wedding_Create = 0x0013,
		FJ_Wedding_Create_Resp = 0x8013,
		FJ_Wedding_Delete = 0x0014,
		FJ_Wedding_Delete_Resp = 0x8014,
		FJ_Task_Query  = 0x0015,
		FJ_Task_Query_Resp = 0x8015,
		FJ_PlayerLevelMoney_Query = 0x0016,
		FJ_PlayerLevelMoney_Query_Resp = 0x8016,
		FJ_Guild_Query = 0x0017,
		FJ_Guild_Query_Resp = 0x8017,
		FJ_Guild_Create = 0x0018,
		FJ_Guild_Create_Resp = 0x8018,
		FJ_Guild_Delete = 0x0019,
		FJ_Guild_Delete_Resp = 0x8019,
		FJ_SocialRelate_Query = 0x0020,
		FJ_SocialRelate_Query_Resp  =0x8020,
		FJ_SocialRelate_Create = 0x0021,
		FJ_SocialRelate_Create_Resp  =0x8021,
		FJ_SocialRelate_Delete = 0x0022,
		FJ_SocialRelate_Delete_Resp  =0x8022,
		FJ_UserBan_Query = 0x0023,
		FJ_UserBan_Query_Resp = 0x8023,
		FJ_UserBan_Close = 0x0024,
		FJ_UserBan_Close_Resp = 0x8024,
		FJ_UserBan_Open = 0x0025,
		FJ_UserBan_Open_Resp = 0x8025,
		FJ_PlayerSkill_Insert = 0x0026,
		FJ_PlayerSkill_Insert_Resp = 0x8026,
		FJ_PlayerSkill_Update= 0x0027,
		FJ_PlayerSkill_Update_Resp = 0x8027,
		FJ_PlayerSkill_Delete= 0x0028,
		FJ_PlayerSkill_Delete_Resp = 0x8028,
		FJ_CharacterInfo_Update = 0x0029,
		FJ_CharacterInfo_Update_Resp = 0x8029,
		FJ_ShortCut_Query = 0x0030,
		FJ_ShortCut_Query_Resp = 0x8030,
		FJ_Message_Batch_Insert  = 0x0031,
		FJ_Message_Batch_Insert_Resp =  0x8031,
		FJ_PlayerPwd_Update =  0x0032,
		FJ_PlayerPwd_Update_Resp  = 0x8032,
		FJ_Task_Insert  = 0x0033,
		FJ_Task_Insert_Resp = 0x8033,
		FJ_Task_Delete  = 0x0034,
		FJ_Task_Delete_Resp = 0x8034,
		FJ_Task_Update  = 0x0035,
		FJ_Task_Update_Resp = 0x8035,
		FJ_Delete_Character = 0x0036,
		FJ_Delete_Character_Resp = 0x8036,
		FJ_Recovery_Character = 0x0037,
		FJ_Recovery_Character_Resp = 0x8037,
		FJ_Guild_QueryAll= 0x0038,
		FJ_Guild_QueryAll_RESP= 0x8038,
		FJ_GS_Query = 0x0039,
		FJ_GS_Query_Resp = 0x8039,
		FJ_BoardList_Query = 0x0040,
		FJ_BoardList_Query_Resp = 0x8040,
		FJ_BoardList_Insert = 0x0041,
		FJ_BoardList_Insert_Resp = 0x8041,
		FJ_BoardList_Delete = 0x0042,
		FJ_BoardList_Delete_Resp = 0x8042,
		FJ_UpdatePwd_Query =  0x0043,
		FJ_UpdatePwd_Query_Resp =  0x8043,
		FJ_PlayerSkill_Query = 0x0044,
		FJ_PlayerSkill_Query_Resp = 0x8044,
		FJ_SkillList_Query = 0x0045,
		FJ_SkillList_Query_Resp = 0x8045,
		FJ_TempPassword_Query = 0x0046,
		FJ_TempPassword_Query_Resp = 0x8046,
		FJ_Currank_Query = 0x0047,
		FJ_Currank_Query_Resp = 0x8047,
		FJ_PWD_Recover = 0x0048,
		FJ_PWD_Recover_Resp = 0x8048,
		FJ_MAP_Query = 0x0049,
		FJ_MAP_Query_Resp = 0x8049,
		FJ_PlayPosition_Update = 0x0050,
		FJ_PlayPosition_Update_Resp = 0x8050,
		FJ_QuestTable_Query = 0x0051,
		FJ_QuestTable_Query_Resp = 0x8051,
		FJ_ItemShop_Style_Query = 0x0052,
		FJ_ItemShop_Style_Query_Resp = 0x8052,
		FJ_ItemShop_QueryAll = 0x0053,
		FJ_ItemShop_QueryAll_Resp = 0x8053,
		FJ_ItemAppend_Style_Query = 0x0054,
		FJ_ItemAppend_Style_Query_Resp = 0x8054,
		FJ_ItemAppend_Query = 0x0055,
		FJ_ItemAppend_Query_Resp = 0x8055,
		
		FJ_ItemAppendList_Query = 0x0056,
		FJ_ItemAppendList_Query_Resp = 0x8056,
		FJ_ItemShop_Delete = 0x0057,
		FJ_ItemShop_Delete_Resp = 0x8057,
		FJ_ItemLog_Query = 0x0058,
		FJ_ItemLog_Query_Resp = 0x8058,
		FJ_ItemLogType_Query = 0x0059,
		FJ_ItemLogType_Query_Resp = 0x8059,
		FJ_GMUser_Qyery = 0x0060,
		FJ_GMUser_Qyery_Resp = 0x8060,
		FJ_GMUser_Update = 0x0061,
		FJ_GMUser_Update_Resp = 0x8061,
		FJ_Auction_Query = 0x0062,
		FJ_Auction_Query_Resp = 0x8062,
		FJ_GMUserLog_Query = 0x0063,
		FJ_GMUserLog_Query_Resp = 0x8063,
		FJ_ItemName_Query = 0x0064,
		FJ_ItemName_Query_Resp = 0x8064,
		FJ_Auction_Del = 0x0065,
		FJ_Auction_Del_Resp = 0x8065,
		FJ_Account_Query = 0x0066,
		FJ_Account_Query_Resp = 0x8066,
		FJ_UserKill_Query = 0x0067,
		FJ_UserKill_Query_Resp = 0x8067,
		FJ_AccountReward_Query = 0x0068,
		FJ_AccountReward_Query_Resp = 0x8068,
		FJ_RewardDetail_Query = 0x0069,
		FJ_RewardDetail_Query_Resp = 0x8069,
		FJ_ExceptLogin_Delete = 0x0070,
		FJ_ExceptLogin_Delete_Resp = 0x8070,
		FJ_GreenGate_Open = 0x0071,
		FJ_GreenGate_Open_Resp = 0x8071,
		FJ_GreenGate_Close = 0x0072,
		FJ_GreenGate_Close_Resp = 0x8072,
		FJ_GreenGate_Query = 0x0073,
		FJ_GreenGate_Query_Resp = 0x8073,
		FJ_AccountDeposit_Query = 0x0074,
		FJ_AccountDeposit_Query_Resp = 0x8074,
		FJ_AccountDeposit_Update = 0x0075,
		FJ_AccountDeposit_Update_Resp = 0x8075,
		FJ_GMAccountDesc_Query = 0x0076,
		FJ_GMAccountDesc_Query_Resp = 0x8076,
		FJ_CreateAccount_Insert =  0x0077,
		FJ_CreateAccount_Insert_Resp = 0x8077,
		FJ_IsCreateAccount_Query =  0x0078,
		FJ_IsCreateAccount_Query_Resp = 0x8078,
		FJ_GMUserBan_Query  =0x0079,
		FJ_GMUserBan_Query_RESP  =0x8079,
		FJ_GuildMember_Query  =0x0080,
		FJ_GuildMember_Query_RESP  =0x8080,
		FJ_CreateTempAccont_Query  =0x0081,
		FJ_CreateTempAccont_Query_RESP  =0x8081,

		FJ_UserBanTime_Create  =0x0082,
		FJ_UserBanTime_Create_RESP  =0x8082,
		FJ_UserLoginCount_Query  =0x0083,
		FJ_UserLoginCount_Query_RESP  =0x8083,
		FJ_JP_Query = 0x0084,
		FJ_JP_Query_RESP = 0x8084,
		FJ_AccountGold_Query = 0x0085,
		FJ_AccountGold_Query_RESP = 0x8085,
		FJ_AccountGold_Update = 0x0086,
		FJ_AccountGold_Update_RESP = 0x8086,
		FJ_GamesUserBan_Query = 0x0087,
		FJ_GamesUserBan_Query_RESP = 0x8087,
		FJ_GamesUserBan_Open = 0x0088,
		FJ_GamesUserBan_Open_RESP = 0x8088,
		FJ_GamesUserUserPoint = 0x0089,
		FJ_GamesUserUserPoint_RESP = 0x8089,
		FJ_GamesUserFjJPInfo = 0x0090,
		FJ_GamesUserFjJPInfo_RESP = 0x8090,
		FJ_GamesUserFjDLTInfo = 0x0091,
		FJ_GamesUserFjDLTInfo_RESP = 0x8091,
		FJ_DelCharinfo_Query=0x0093,
		FJ_DelCharinfo_Query_RESP=0x8093,
		FJ_Credit_time_Query=0x0094,
		FJ_Credit_time_Query_RESP=0x8094,
		FJ_MakeDream_Query=0x0095,
		FJ_MakeDream_Query_RESP=0x8095,
		FJ_Credit_time_Update=0x0096,
		FJ_Credit_time_Update_RESP=0x8096,
		FJ_GuildWar_Query = 0x0097,//����ս����Ϣ
		FJ_GuildWar_Query_RESP = 0x8097,//����ս����Ϣ

		/// <summary>
		/// ���쮳�
		/// </summary>
		RC_Character_Query = 0x0001,
		RC_Character_Query_Resp = 0x8001,
		RC_UserLoginOut_Query = 0x0002,
		RC_UserLoginOut_Query_Resp = 0x8002,
		RC_UserLogin_Del = 0x0003,
		RC_UserLogin_Del_Resp = 0x8003,
		RC_RcCode_Query = 0x0004,
		RC_RcCode_Query_Resp = 0x8004,
		RC_RcUser_Query = 0x0005,
		RC_RcUser_Query_Resp = 0x8005,
		CS_UserBan_Open = 0x0006,
		CS_UserBan_Open_Resp = 0x8006,
		CS_UserBan_Close = 0x0007,
		CS_UserBan_Close_Resp = 0x8007,
		CS_UserBan_Query = 0x0008,
		CS_UserBan_Query_Resp = 0x8008,
		CS_UserCarinfo_Query = 0x0009,
		CS_UserCarinfo_Query_Resp = 0x8009,
		CS_Account_Query = 0x0010,
		CS_Account_Query_Resp = 0x8010,
		
		CS_GMAccount_Create = 0x0011,
		CS_GMAccount_Create_Resp = 0x8011,
		CS_ItemList_Query = 0x0012,
		CS_ItemList_Query_Resp = 0x8012,
		CS_ItemShop_Insert = 0x0013,
		CS_ItemShop_Insert_Resp = 0x8013,
		CS_ItemShop_Delete = 0x0014,
		CS_ItemShop_Delete_Resp = 0x8014,
		RC_Character_Update = 0x0015,
		RC_Character_Update_Resp = 0x8015,
		CS_UserIteminfo_Query = 0x0016,
		CS_UserIteminfo_Query_Resp = 0x8016,
		CS_UserSYSmailinfo_Query = 0x0018,
		CS_UserSYSmailinfo_Query_Resp = 0x8018,
		CS_UserSPAmailinfo_Query = 0x0019,
		CS_UserSPAmailinfo_Query_Resp = 0x8019,
		CS_Usermailinfo_Del = 0x0020,
		CS_Usermailinfo_Del_Resp = 0x8020,
		CS_CirculationLogByReceiver_Query = 0x0021,
		CS_CirculationLogByReceiver_Query_Resp = 0x8021,
		CS_CirculationLogBySender_Query = 0x0022,
		CS_CirculationLogBySender_Query_Resp = 0x8022,
		CS_DealLogByPlayerID_Query = 0x0023,
		CS_DealLogByPlayerID_Query_Resp = 0x8023,
		CS_Carinfo_Update = 0x0024,
		CS_Carinfo_Update_Resp = 0x8024,

		CS_bulletin_Query = 0x0025,
		CS_bulletin_Query_Resp = 0x8025,
		CS_bulletin_Insert = 0x0026,
		CS_bulletin_Insert_Resp = 0x8026,
		CS_Onlinebulletin_Insert = 0x0027,
		CS_Onlinebulletin_Insert_Resp = 0x8027,
		
		CS_ChangeGameMultiple_Insert = 0x0028,
		CS_ChangeGameMultiple_Insert_Resp = 0x8028,
		CS_ActiveCode_Query = 0x0029,
		CS_ActiveCode_Query_Resp = 0x8029,
		CS_ActiveAccount_Query = 0x0030,
		CS_ActiveAccount_Query_Resp = 0x8030,
		CS_GMAccount_Query = 0x0031,
		CS_GMAccount_Query_Resp = 0x8031,
		CS_bulletin_Del = 0x0032,
		CS_bulletin_Del_Resp = 0x8032,
		CS_Accountbyid_Query = 0x0033,
		CS_Accountbyid_Query_Resp= 0x8033,
		CS_PlayerPwd_Update= 0x0034,
		CS_PlayerPwd_Update_RESP = 0x8034,
		CS_PlayerPwd_Query= 0x0035,
		CS_PlayerPwd_Query_RESP = 0x8035,
		CS_PlayerPwd_Recover= 0x0036,
		CS_PlayerPwd_Recover_RESP = 0x8036,
		
		CS_PlayerLogininfo_Query= 0x0037, //��½��Ϣ��ѯ
		CS_PlayerLogininfo_Query_RESP = 0x8037,
		CS_CarDetail_Query= 0x0038,//������ϸ��Ϣ��ѯ
		CS_CarDetail_Query_RESP = 0x8038,
		CS_PlayerBestScore_Query= 0x0039,//�����óɼ���ѯ
		CS_PlayerBestScore_Query_RESP = 0x8039,
		CS_Donttalk_Query=0x0040,
		CS_Donttalk_Query_RESP=0x8040,
		CS_Talk_Query=0x0041,
		CS_Talk_Query_RESP=0x8041,
		CS_TeamMemberOfTeam_Query=0x0042,//��ȡָ�����ӵ����ж�Ա��Ϣ
		CS_TeamMemberOfTeam_Query_RESP=0x8042,//��ȡָ�����ӵ����ж�Ա��Ϣ
		CS_GetTeamOfPlayer_Query=0x0043,//��ȡ����������ӵ���Ϣ
		CS_GetTeamOfPlayer_Query_RESP=0x8043,//��ȡ����������ӵ���Ϣ
		CS_GetTeamMember_Query=0x0044,//��ȡ���Ӷ�Ա��Ϣ
		CS_GetTeamMember_Query_RESP=0x8044,//��ȡ���Ӷ�Ա��Ϣ
		/// <summary>
		/// 
		/// ���߷ɳ�
		/// </summary>
		RayCity_Character_Query = 0x0001,
		RayCity_Character_Query_Resp = 0x8001,
		RayCity_CharacterState_Query = 0x0002,
		RayCity_CharacterState_Query_Resp = 0x8002,
		RayCity_RaceState_Query = 0x0003,
		RayCity_RaceState_Query_Resp = 0x8003,
		RayCity_InventoryList_Query = 0x0004,
		RayCity_InventoryList_Query_Resp = 0x8004,
		RayCity_InventoryDetail_Query = 0x0005,
		RayCity_InventoryDetail_Query_Resp = 0x8005,
		RayCity_CarList_Query = 0x0006,
		RayCity_CarList_Query_Resp = 0x8006,
		RayCity_Guild_Query = 0x0007,
		RayCity_Guild_Query_Resp = 0x8007,
		RayCity_QuestLog_Query = 0x0008,
		RayCity_QuestLog_Query_Resp = 0x8008,
		RayCity_MissionLog_Query = 0x0009,
		RayCity_MissionLog_Query_Resp = 0x8009,
		RayCity_DealLog_Query = 0x0010,
		RayCity_DealLog_Query_Resp = 0x8010,
		RayCity_FriendList_Query = 0x0011,
		RayCity_FriendList_Query_Resp = 0x8011,
		RayCity_BasicAccount_Query = 0x0012,
		RayCity_BasicAccount_Query_Resp = 0x8012,
		RayCity_GuildMember_Query = 0x0013,
		RayCity_GuildMember_Query_Resp = 0x8013,
		RayCity_BasicCharacter_Query = 0x0014,
		RayCity_BasicCharacter_Query_Resp = 0x8014,
		RayCity_BuyCar_Query = 0x0015,
		RayCity_BuyCar_Query_Resp = 0x8015,
		RayCity_ConnectionLog_Query = 0x0016,
		RayCity_ConnectionLog_Query_Resp = 0x8016,
		RayCity_CarInventory_Query = 0x0017,
		RayCity_CarInventory_Query_Resp = 0x8017,
		RayCity_ConnectionState_Query = 0x0018,
		RayCity_ConnectionState_Resp = 0x8018,
		RayCity_ItemShop_Insert = 0x0019,
		RayCity_ItemShop_Insert_Resp = 0x8019,
		RayCity_ItemShop_Query = 0x0020,
		RayCity_ItemShop_Query_Resp = 0x8020,
		RayCity_MoneyLog_Query = 0x0021,
		RayCity_MoneyLog_Query_Resp = 0x8021,
		RayCity_RaceLog_Query = 0x0022,
		RayCity_RaceLog_Query_Resp = 0x8022,
		RayCity_AddMoney = 0x0023,
		RayCity_AddMoney_Resp = 0x8023,
		RayCity_Skill_Query = 0x0024,
		RayCity_Skill_Query_Resp = 0x8024,
		RayCity_PlayerSkill_Query = 0x0025,
		RayCity_PlayerSkill_Query_Resp = 0x8025,
		RayCity_PlayerSkill_Delete = 0x0026,
		RayCity_PlayerSkill_Delete_Resp = 0x8026,
		RayCity_PlayerSkill_Insert= 0x0027,
		RayCity_PlayerSkill_Insert_Resp = 0x8027,
		RayCity_ItemType_Query= 0x0028,
		RayCity_ItemType_Query_Resp = 0x8028,
		RayCity_GMUser_Query= 0x0029,
		RayCity_GMUser_Query_Resp = 0x8029,
		RayCity_GMUser_Update= 0x0030,
		RayCity_GMUser_Update_Resp = 0x8030,
		RayCity_TradeInfo_Query= 0x0031,
		RayCity_TradeInfo_Query_Resp = 0x8031,
		RayCity_TradeDetail_Query = 0x0032,
		RayCity_TradeDetail_Query_Resp = 0x8032,
		RayCity_SetPos_Update = 0x0033,
		RayCity_SetPos_Update_Resp = 0x8033,
		RayCity_PlayerAccount_Create = 0x0034,
		RayCity_PlayerAccount_Create_Resp = 0x8034,
		RayCity_WareHousePwd_Update = 0x0035,
		RayCity_WareHousePwd_Update_Resp = 0x8035,
		RayCity_BingoCard_Query = 0x0036,
		RayCity_BingoCard_Query_Resp = 0x8036,
		RayCity_UserCharge_Query = 0x0037,
		RayCity_UserCharge_Query_Resp = 0x8037,
		RayCity_ItemConsume_Query = 0x0038,
		RayCity_ItemConsume_Query_Resp = 0x8038,
		RayCity_UserMails_Query = 0x0039,
		RayCity_UserMails_Query_Resp = 0x8039,
		RayCity_CashItemDetailLog_Query = 0x0040,
		RayCity_CashItemDetailLog_Query_Resp = 0x8040,
		RayCity_Coupon_Query = 0x0041,
		RayCity_Coupon_Query_Resp = 0x8041,
		RayCity_ActiveCard_Query = 0x0042,
		RayCity_ActiveCard_Query_Resp = 0x8042,

		RayCity_BoardList_Query = 0x0043,
		RayCity_BoardList_Query_Resp = 0x8043,
		RayCity_BoardList_Insert = 0x0044,
		RayCity_BoardList_Insert_Resp = 0x8044,
		RayCity_BoardList_Delete = 0x0045,
		RayCity_BoardList_Delete_Resp = 0x8045,
		/// <summary>
		/// ����
		/// </summary>
		RICH_BOARDMESSAGE_REQ = 0x0001,
		RICH_BOARDMESSAGE_REQ_RESP = 0x8001,
		RICH_BOARDTASK_INSERT = 0x0002,
		RICH_BOARDTASK_INSERT_RESP = 0x8002,
		RICH_BOARDTASK_QUERY = 0x0003,
		RICH_BOARDTASK_QUERY_RESP = 0x8003,
		RICH_BOARDTASK_UPDATE = 0x0004,
		RICH_BOARDTASK_UPDATE_RESP = 0x8004,
		RICH_NEWS_QUERY = 0x0005,
		RICH_NEWS_QUERY_RESP = 0x8005,
		RICH_NEWS_INSERT = 0x0006,
		RICH_NEWS_INSERT_RESP = 0x8006,
		RICH_NEWS_DELETE = 0x0007,
		RICH_NEWS_DELETE_RESP = 0x8007,
		RICH_CHANNELS_QUERY = 0x0008,
		RICH_CHANNELS_QUERY_RESP = 0x8008,
		RICH_ACCOUNT_QUERY = 0x0009,
		RICH_ACCOUNT_QUERY_RESP = 0x8009,
		RICH_CHARACTER_QUERY = 0x0010,
		RICH_CHARACTER_QUERY_RESP = 0x8010,
		RICH_KICKPLAYER_REQ = 0x0011,
		RICH_KICKPLAYER_REQ_RESP = 0x8011,
		RICH_Iteminfo_QUERY = 0x0012,
		RICH_Iteminfo_QUERY_RESP = 0x8012,
		RICH_UserLoginLog_QUERY = 0x0013,
		RICH_UserLoginLog_QUERY_RESP = 0x8013,
		RICH_UserMailLog_QUERY = 0x0014,
		RICH_UserMailLog_QUERY_RESP = 0x8014,

		RICH_UserDropItem_QUERY = 0x0015,
		RICH_UserDropItem_QUERY_RESP = 0x8015,
		RICH_Userlobbyitem_QUERY = 0x0016,
		RICH_Userlobbyitem_QUERY_RESP = 0x8016,
		Rich_ItemShop_Query = 0x0017,
		Rich_ItemShop_Query_Resp = 0x8017,
		Rich_Userinfo_update = 0x0018,
		Rich_Userinfo_update_Resp = 0x8018,
		Rich_Sendmail_Insert = 0x0019,
		Rich_Sendmail_Insert_Resp = 0x8019,
		Rich_PlayerPwd_Update =  0x0020,
		Rich_PlayerPwd_Update_Resp  = 0x8020,
		Rich_PlayerPwd_Query =  0x0021,
		Rich_PlayerPwd_Query_Resp  = 0x8021,
		Rich_PlayerPwd_Recover =  0x0022,
		Rich_PlayerPwd_Recover_Resp  = 0x8022,
		
		Rich_Account_Close = 0x0023,//��ͣ����ʺ�
		Rich_Account_Close_RESP = 0x8023,//��ͣ����ʺ���Ӧ
		Rich_Account_Open = 0x0024,//�������ʺ�
		Rich_Account_Open_RESP= 0x8024,//�������ʺ���Ӧ
		Rich_Account_BANISHMENT_QUERY = 0x0025,//��ҷ�ͣ�ʺŲ�ѯ״̬
		Rich_Account_BANISHMENT_QUERY_RESP = 0x8025,//��ҷ�ͣ�ʺŲ�ѯ״̬��Ӧ
		Rich_BanAccount_Query = 0x0026,//��ѯ���з�ͣ����ʺ���Ϣ
		Rich_BanAccount_Query_Resp = 0x8026,//��ѯ���з�ͣ����ʺ���Ϣ
		Rich_Buyinfo_Query = 0x0027,
		Rich_Buyinfo_Query_Resp = 0x8027,
		Rich_UserCharge_Query = 0x0028,
		Rich_UserCharge_Query_Resp = 0x8028,
		Rich_UserPayment_Query = 0x0029,
		Rich_UserPayment_Query_Resp = 0x8029,
		Rich_PaymentLog_Query = 0x0030,
		Rich_PaymentLog_Query_Resp = 0x8030,
		Rich_ItemConsume_Query = 0x0031,
		Rich_ItemConsume_Query_Resp = 0x8031,
		Rich_PlayerCard_Kick = 0x0032,
		Rich_PlayerCard_Kick_Resp = 0x8032,
		Rich_PlayerMoneyLog_Query = 0x0033,
		Rich_PlayerMoneyLog_Query_Resp = 0x8033,
		Rich_Playerlottery_Query = 0x0034,
		Rich_Playerlottery_Resp = 0x8034,
		Rich_PlayerActivepropLog_Query = 0x0035,
		Rich_PlayerActivepropLog_Query_Resp = 0x8035,
		Rich_PlayerTrades_Query = 0x0036,
		Rich_PlayerTrades_Resp = 0x8036,

		/// <summary>
		/// ����ɭ��
		/// </summary>
		MF_ACCOUNTCODE_QUERY = 0x0001,
		MF_ACCOUNTCODE_QUERY_RESP = 0x8001,
		MF_ACCOUNT_QUERY = 0x0002,
		MF_ACCOUNT_QUERY_RESP = 0x8002,

		MF_Charinfo_QUERY = 0x0003,
		MF_Charinfo_QUERY_RESP = 0x8003,

		Mf_Confraternity_Query= 0x0004,
		Mf_Confraternity_Query_RESP = 0x8004,

		Mf_Useriteminfo_Query= 0x0005,
		Mf_Useriteminfo_Query_RESP = 0x8005,

		Mf_Userpetinfo_Query= 0x0006,
		Mf_Userpetinfo_Query_RESP = 0x8006,

		Mf_petCardgroup_Query= 0x0007,
		Mf_petCardgroup_Query_RESP = 0x8007,

		Mf_Petiteminfo_Query= 0x0008,
		Mf_Petiteminfo_Query_RESP = 0x8008,

		Mf_UserLogin_Query= 0x0009,
		Mf_UserLogin_Query_RESP = 0x8009,

		Mf_Userpwd_Query= 0x0010,
		Mf_Userpwd_Query_RESP = 0x8010,

		Mf_Userpwd_update= 0x0011,
		Mf_Userpwd_update_RESP = 0x8011,

		Mf_BanAccount_Query= 0x0012,
		Mf_BanAccount_Query_RESP = 0x8012,

		Mf_AllBanAccount_Query= 0x0013,
		Mf_AllBanAccount_Query_RESP = 0x8013,

		Mf_Account_Open= 0x0014,
		Mf_Account_Open_RESP = 0x8014,

		Mf_Account_Close= 0x0015,
		Mf_Account_Close_RESP = 0x8015,
		Mf_PetSkill_Query= 0x0016,
		Mf_PetSkill_Query_RESP = 0x8016,
		Mf_PetGene_Query= 0x0017,//����
		Mf_PetGene_Query_RESP = 0x8017,//����
		Mf_Guildinfo_Query= 0x0018,
		Mf_Guildinfo_Query_RESP = 0x8018,
		Mf_GuildMemberinfo_Query= 0x0019,
		Mf_GuildMemberinfo_Query_RESP = 0x8019,
		Mf_Gardeninfo_Query= 0x0020,
		Mf_Gardeninfo_Query_RESP = 0x8020,
		Mf_GrdenIteminfo_Query= 0x0021,
		Mf_GrdenIteminfo_Query_RESP = 0x8021,
		Mf_GrdenPlantsinfo_Query= 0x0022,
		Mf_GrdenPlantsinfo_Query_RESP = 0x8022,
		Mf_GrdenNinki_Query= 0x0023,
		Mf_GrdenNinki_Query_RESP = 0x8023,
		Mf_PlayerPwd_Update= 0x0024,
		Mf_PlayerPwd_Update_RESP = 0x8024,
		Mf_PlayerPwd_Query= 0x0025,
		Mf_PlayerPwd_Query_RESP = 0x8025,
		Mf_PlayerPwd_Recover= 0x0026,
		Mf_PlayerPwd_Recover_RESP = 0x8026,
		Mf_PlayerFriend_Query =  0x0027,
		Mf_PlayerFriend_Query_RESP =  0x8027,
		Mf_Guildname_Update= 0x0028,
		Mf_Guildname_Update_RESP = 0x8028,
		Mf_GuildLevel_Update = 0x0029,
		Mf_GuildLevel_Update_RESP = 0x8029,
		Mf_PlayerMailinfoSend_Query = 0x0030,
		Mf_PlayerMailinfoSend_Query_RESP = 0x8030,
		Mf_PlayerMailinfoRecive_Query = 0x0031,
		Mf_PlayerMailinfoRecive_Query_RESP = 0x8031,
		Mf_bulletin_Query = 0x0032,
		Mf_bulletin_Query_Resp = 0x8032,
		Mf_bulletin_Insert = 0x0033,
		Mf_bulletin_Insert_Resp = 0x8033,
		Mf_bulletin_Update = 0x0034,
		Mf_bulletin_Update_Resp = 0x8034,
		Mf_BoardTask_OwnerQuery = 0x0035,
		Mf_BoardTask_OwnerQuery_Resp = 0x8035,
		Mf_PlayerTask_Query= 0x0036,
		Mf_PlayerTask_Query_RESP = 0x8036,
		Mf_PlayerPetTask_Query= 0x0037,
		Mf_PlayerPetTask_Query_RESP = 0x8037,
		Mf_PlayerPetTaskLog_Query= 0x0038,
		Mf_PlayerPetTaskLog_Query_RESP = 0x8038,
		Mf_PlayerTaskLog_Query= 0x0039,
		Mf_PlayerTaskLog_Query_RESP = 0x8039,
		MF_Charinfo_Update = 0x0040,
		MF_Charinfo_Update_RESP = 0x8040,
		MF_Creditcard_QUERY = 0x0041,
		MF_Creditcard_QUERY_RESP = 0x8041,
		MF_GardenRsinfo_QUERY = 0x0042,
		MF_GardenRsinfo_QUERY_RESP = 0x8042,
		MF_Iteminfo_QUERY = 0x0043,
		MF_Iteminfo_QUERY_RESP = 0x8043,
		MF_Iteminfo_INSERT = 0x0044,
		MF_Iteminfo_INSERT_RESP = 0x8044,
		MF_Puzzleinfo_QUERY = 0x0045,
		MF_Puzzleinfo_QUERY_RESP = 0x8045,
		MF_PlayerQuest_Del = 0x0046,
		MF_PlayerQuest_Del_RESP = 0x8046,
		MF_PetQuest_Del = 0x0047,
		MF_PetQuest_Del_RESP = 0x8047,
		MF_News_Query = 0x0048,
		MF_News_Query_RESP = 0x8048,
		MF_News_Del= 0x0049,
		MF_News_Del_RESP= 0x8049,
		MF_News_Insert= 0x0050,
		MF_News_Insert_RESP = 0x8050,
		MF_CardGroup_Query = 0x0051,
		MF_CardGroup_Query_RESP = 0x8051,
		MF_PetLevel_Update = 0x0052,
		MF_PetLevel_Update_RESP = 0x8052,
		MF_PetLevel_Query = 0x0053,
		MF_PetLevel_Query_RESP = 0x8053,
		MF_CardLevel_Update = 0x0054,
		MF_CardLevel_Update_RESP = 0x8054,
		MF_card_upgrade_log= 0x0055,
		MF_card_upgrade_log_RESP = 0x8055,
		MF_cash_change_log= 0x0056,
		MF_cash_change_log_RESP = 0x8056,
		MF_credit_card_change_log= 0x0057,
		MF_credit_card_change_log_RESP = 0x8057,
		MF_exp_change_log= 0x0058,
		MF_exp_change_log_RESP = 0x8058,
		MF_gcash_change_log= 0x0059,
		MF_gcash_change_log_RESP = 0x8059,
		MF_growth_change_log= 0x0060,
		MF_growth_change_log_RESP = 0x8060,
		MF_item_change_log= 0x0061,
		MF_item_change_log_RESP = 0x8061,
		MF_item_insert_log= 0x0062,
		MF_item_insert_log_RESP = 0x8062,
		MF_item_trade_log= 0x0063,
		MF_item_trade_log_RESP = 0x8063,
		Mf_KICKPLAYER = 0x0064,
		Mf_KICKPLAYER_RESP = 0x8064,
		Mf_PetGrowh_Update = 0x0065,
		Mf_PetGrowh_Update_RESP = 0x8065,
		Mf_Everydaylog_Query= 0x0066,
		Mf_Everydaylog_Query_RESP = 0x8066,
		Mf_MemberVip_Update = 0x0067,
		Mf_MemberVip_Update_RESP = 0x8067,
		Mf_MemberVip_Query = 0x0068,
		Mf_MemberVip_Query_RESP = 0x8068,
		Mf_UserActiveKey_Query = 0x0069,
		Mf_UserActiveKey_Query_RESP = 0x8069,
		Mf_UserCharge_Query = 0x0070,
		Mf_UserCharge_Query_RESP = 0x8070,
		Mf_DelIteminfo_Del = 0x0071,
		Mf_DelIteminfo_Del_RESP = 0x8071,
		Mf_UseriteminfoBychest_Query= 0x0072,
		Mf_UseriteminfoBychest_Query_RESP = 0x8072,
		Mf_PetiteminfoBychest_Query= 0x0073,
		Mf_PetiteminfoBychest_Query_RESP = 0x8073,
		Mf_UserNickname_Query=0x0074,
		Mf_UserNickname_Query_Resp =0x8074,
		Mf_UserNickname_Update=0x0075,
		Mf_UserNickname_Update_Resp =0x8075,
		Mf_Userbugle_log_Query=0x0076,
		Mf_Userbugle_log_Query_Resp =0x8076,
		Mf_Bulletinonline_Update = 0x0077,//�������
		Mf_Bulletinonline_Update_RESP = 0x8077,
		Mf_Bulletinonline_Query = 0x0078,//�����ѯ
		Mf_Bulletinonline_Query_RESP = 0x8078,
		Mf_Bulletinonline_Del = 0x0079,//����ɾ��
		Mf_Bulletinonline_Del_RESP = 0x8079,
		Mf_Bulletinonline_Insert = 0x0079,//��������
		Mf_Bulletinonline_Insert_RESP = 0x8079,
		Mf_ResetPetStatus_Query = 0x0081,//����״̬����
		Mf_ResetPetStatus_Query_RESP = 0x8081,
		Mf_ResetZoneStatus_Query = 0x0082,//��½��ͼ����
		Mf_ResetZoneStatus_Query_RESP = 0x8082,
		Mf_PetGeneAll_Query = 0x0083,//�������Բ�ѯ
		Mf_PetGeneAll_Query_Query_RESP = 0x8083,
		Mf_PlayerPet_Insert = 0x0084,//���ӳ��ﵰ
		Mf_PlayerPet_Insert_RESP = 0x8084,
		Mf_PlayerPetSkillCard_Insert = 0x0085,//���Ӽ��ܿ�
		Mf_PlayerPetSkillCard_Insert_RESP = 0x8085,

		Mf_PlayerActivetime_Query = 0x0086,//����ʱ���ѯ
		Mf_PlayerActivetime_Query_RESP = 0x8086,
		Mf_Married_Query=0x0087,//�����־
		Mf_Married_Query_RESP=0x8087,
		Mf_Divorce_Query=0x0088,//�����־
		Mf_Divorce_Query_RESP=0x8088,

		Mf_Married_State_Query = 0x0089,//����״��
		Mf_Married_State_Query_RESP = 0x8089,//����״��
		Mf_RidingPet_Info_Query = 0x0090,//�û�����ѯ
		Mf_RidingPet_Info_Query_RESP = 0x8090,//�û�����ѯ

		Mf_RidingPet_BagBox_Query = 0x0091,//�û���豳����ѯ
		Mf_RidingPet_BagBox_Query_RESP = 0x8091,//�û���豳����ѯ

		MF_Activity_HpSp_Query = 0x0092,//HP/SP�Զ��ָ�����
		MF_Activity_HpSp_Query_RESP = 0x8092,//HP/SP�Զ��ָ�����

		MF_UpdateGene_Query = 0x0093,//ϴ����
		MF_UpdateGene_Query_RESP = 0x8093,//ϴ����

		MF_GuildWar_Query = 0x0094,//����ս
		MF_GuildWar_Query_RESP = 0x8094,//����ս

		MF_GuildTradeWar_Query = 0x0095,//����ó��ս
		MF_GuildTradeWar_Query_RESP = 0x8095,//����ó��ս

		MF_GuildWarEnd_Query = 0x0096,//����ս��ɼ�¼
		MF_GuildWarEnd_Query_RESP = 0x8096,//����ս��ɼ�¼

		/// <summary>
		/// SD�ߴ�
		/// </summary>
		SD_ActiveCode_Query = 0x0001,
		SD_ActiveCode_Query_Resp = 0x8001,

		SD_Account_Query= 0x0002,//�ʺŲ�ѯ
		SD_Account_Query_Resp= 0x8002,
		SD_AccountDetail_Query= 0x0012,//�ʺ���ϸ��Ϣ��ѯ
		SD_AccountDetail_Query_Resp= 0x8012,
		SD_UserIteminfo_Query= 0x0003,//�û�������Ϣ��ѯ
		SD_UserIteminfo_Query_Resp= 0x8003,
		SD_UserLoginfo_Query= 0x0013,//�û���½��Ϣ��ѯ
		SD_UserLoginfo_Query_Resp= 0x8013,
		SD_UserMailinfo_Query= 0x0004,//�û��ʼ���Ϣ��ѯ
		SD_UserMailinfo_Query_Resp= 0x8004,
		SD_UserGuildinfo_Query= 0x0005,//�û�������Ϣ��ѯ
		SD_UserGuildinfo_Query_Resp= 0x8005,
		SD_UserStorageinfo_Query= 0x0006,//�û��ֿ���Ϣ��ѯ
		SD_UserStorageinfo_Query_Resp= 0x8006,
		SD_UserAdditem_Add= 0x0007,//���ӵ���
		SD_UserAdditem_Add_Resp= 0x8007,
		SD_UserAdditem_Del= 0x0011,//ɾ������
		SD_UserAdditem_Del_Resp= 0x8011,
		SD_BanUser_Query= 0x0008,//��ѯ��ͣ�û�
		SD_BanUser_Query_Resp= 0x8008,
		SD_BanUser_Ban= 0x0009,//��ͣ�û�
		SD_BanUser_Ban_Resp= 0x8009,
		SD_BanUser_UnBan= 0x0010,//����û�
		SD_BanUser_UnBan_Resp= 0x8010,
		SD_Item_MixTree_Query = 0x0020,	//��һ������
		SD_Item_MixTree_Query_Resp = 0x8020,
		SD_Item_UserUnits_Query = 0x0014,	//��һ�����Ϣ
		SD_Item_UserUnits_Query_Resp = 0x8014,
		SD_Item_UserCombatitems_Query = 0x0015,	//���ս������
		SD_Item_UserCombatitems_Query_Resp = 0x8015,
		SD_Item_Operator_Query = 0x0016,	//��Ҹ��ٵ���
		SD_Item_Operator_Query_Resp = 0x8016,
		SD_Item_Paint_Query = 0x0017,	//���Ϳ�ϵ���
		SD_Item_Paint_Query_Resp = 0x8017,
		SD_Item_Skill_Query = 0x00018,//��Ҽ��ܵ���
		SD_Item_Skill_Query_Resp = 0x8018,//��Ҽ��ܵ���
		SD_Item_Sticker_Query = 0x0019,//��ұ�ǩ����
		SD_Item_Sticker_Query_Resp = 0x8019,//��ұ�ǩ����
		SD_UserGrift_Query = 0x0022,//������Ϣ��ѯ
		SD_UserGrift_Query_Resp = 0x8022,//������Ϣ��ѯ
		SD_KickUser_Query = 0x0021,//���û�����
		SD_KickUser_Query_Resp = 0x8021,//���û�����
		SD_SendNotes_Query = 0x0023,//���͹���
		SD_SendNotes_Query_Resp = 0x8023,//���͹���
		SD_SeacrhNotes_Query = 0x0024,//������Ϣ��ѯ
		SD_SeacrhNotes_Query_Resp = 0x8024,//������Ϣ��ѯ
		SD_ItemType_Query = 0x0025,//��ȡ��������
		SD_ItemType_Query_Resp = 0x8025,//��ȡ��������
		SD_ItemList_Query = 0x0026,//��ȡ�����б�
		SD_ItemList_Query_Resp = 0x8026,//��ȡ�����б�
		SD_TmpPassWord_Query = 0x0027,//��ʱ����
		SD_TmpPassWord_Query_Resp = 0x8027,//��ʱ����
		SD_ReTmpPassWord_Query = 0x0028,//�ָ���ʱ����
		SD_ReTmpPassWord_Query_Resp = 0x8028,//�ָ���ʱ����
		SD_SearchPassWord_Query = 0x0029,//��ѯ��ʱ����
		SD_SearchPassWord_Query_Resp = 0x8029,//��ѯ��ʱ����
		SD_UpdateExp_Query = 0x0030,//�޸ĵȼ�
		SD_UpdateExp_Query_Resp = 0x8030,//�޸ĵȼ�
		SD_Grift_FromUser_Query = 0x0031,//������������Ϣ��ѯ
		SD_Grift_FromUser_Query_Resp = 0x8031,//������������Ϣ��ѯ
		SD_Grift_ToUser_Query = 0x0032,//������������Ϣ��ѯ
		SD_Grift_ToUser_Query_Resp = 0x8032,//������������Ϣ��ѯ
		SD_TaskList_Update = 0x0033,//�޸Ĺ���
		SD_TaskList_Update_Resp = 0x8033,//�޸Ĺ���
		SD_Account_Active_Query = 0x0034,//ͨ���ʺŲ�ѯ������Ϣ
		SD_Account_Active_Query_Resp = 0x8034,//ͨ���ʺŲ�ѯ������Ϣ
		SD_BuyLog_Query = 0x0035,//��ҹ������
		SD_BuyLog_Query_Resp = 0x8035,//��ҹ������
		SD_Delete_ItemLog_Query = 0x0036,//���ɾ�����߼�¼
		SD_Delete_ItemLog_Query_Resp = 0x8036,//���ɾ�����߼�¼
		SD_LogInfo_Query = 0x0037,//�����־��¼
		SD_LogInfo_Query_Resp = 0x8037,//�����־��¼
		SD_Firend_Query = 0x0038,//��Һ��Ѳ�ѯ
		SD_Firend_Query_Resp = 0x8038,//��Һ��Ѳ�ѯ
		SD_UserRank_query = 0x0039,//���������ѯ
		SD_UserRank_query_Resp = 0x8039,//���������ѯ
		SD_UpdateUnitsExp_Query = 0x0040,//�޸���һ���ȼ�
		SD_UpdateUnitsExp_Query_Resp = 0x8040,//�޸���һ���ȼ�
		SD_UnitsItem_Query = 0x0041,//��ѯ�������
		SD_UnitsItem_Query_Resp = 0x8041,//��ѯ�������
		SD_GetGmAccount_Query = 0x0042,//��ѯGM�˺�
		SD_GetGmAccount_Query_Resp = 0x8042,//��ѯGM�˺�
		SD_UpdateGmAccount_Query = 0x0043,//�޸�GM�˺�
		SD_UpdateGmAccount_Query_Resp = 0x8043,//�޸�GM�˺�
		SD_UpdateMoney_Query = 0x0044,//�޸�G��
		SD_UpdateMoney_Query_Resp = 0x8044,//�޸�G��
		SD_Card_Info_Query = 0x0045,//����/��ʯ����ѯ
		SD_Card_Info_Query_Resp = 0x8045,//����/��ʯ����ѯ
		SD_UserAdditem_Add_All = 0x0046,//�������ӵ���
		SD_UserAdditem_Add_All_Resp = 0x8046,//�������ӵ���

		SD_ReGetUnits_Query = 0x0047,//�ָ�����
		SD_ReGetUnits_Query_Resp = 0x8047,//�ָ�����

		#region ħ������2
		/// <summary>
		/// ħ������2
		/// </summary>
		//��ɫ����
		MAGIC_Account_Query = 0x0001,//��ɫ��������
		MAGIC_Account_Query_Resp = 0x8001,//��ɫ��������
		MAGIC_Account_Detail_Query = 0x0002, //��ɫ��ϸ����
		MAGIC_Account_Detail_Query_Resp = 0x8002, //��ɫ��ϸ����
		MAGIC_Account_Attribute_Query = 0x0003,//��ɫ��������
		MAGIC_Account_Attribute_Query_Resp = 0x8003,//��ɫ��������
		MAGIC_Account_Guild_Query = 0x0004,//��ɫ��������
		MAGIC_Account_Guild_Query_Resp = 0x8004,//��ɫ��������
		MAGIC_Account_Title_Query = 0x0005,//��ɫ�ƺ�����
		MAGIC_Account_Title_Query_Resp = 0x8005,//��ɫ�ƺ�����
		MAGIC_Account_Address_Query = 0x0006,//��ɫ����ϵ
		MAGIC_Account_Address_Query_Resp = 0x8006,//��ɫ����ϵ
		MAGIC_Account_Skill_Query = 0x0007,//��ɫ������Ϣ
		MAGIC_Account_Skill_Query_Resp = 0x8007,//��ɫ������Ϣ
		//������Ʒ����
		MAGIC_CharItem_Query = 0x0008,//��ɫ���ϵ�����Ϣ
		MAGIC_CharItem_Query_Resp = 0x8008,//��ɫ���ϵ�����Ϣ
		MAGIC_TempItem_Query = 0x0009,//��ʱ������Ϣ
		MAGIC_TempItem_Query_Resp = 0x8009,//��ʱ������Ϣ
		MAGIC_ShopItem_Query = 0x0010,//�̳���Ʒ��ȡ
		MAGIC_ShopItem_Query_Resp = 0x8010,//�̳���Ʒ��ȡ
		//������Ʒ����
		MAGIC_BankInfo_Query = 0x0011,//���д����Ϣ
		MAGIC_BankInfo_Query_Resp = 0x8011,//���д����Ϣ
		MAGIC_BankItem_Query = 0x0012,//������Ʒ��Ϣ
		MAGIC_BankItem_Query_Resp = 0x8012,//������Ʒ��Ϣ
		//������Ϣ
		MAGIC_PetInfo_Query = 0x0013,//�����������
		MAGIC_PetInfo_Query_Resp = 0x8013,//�����������
		MAGIC_PetInfo_Detail_Query = 0x0014,//������ϸ����
		MAGIC_PetInfo_Detail_Query_Resp = 0x8014,//������ϸ����
		MAGIC_PetItem_Query = 0x0015,//���ﱳ����Ϣ
		MAGIC_PetItem_Query_Resp = 0x8015,//	���ﱳ����Ϣ
		MAGIC_PetSkill_Query = 0x0016,//���＼����Ϣ
		MAGIC_PetSkill_Query_Resp = 0x8016,//	���＼����Ϣ
		//����
		MAGIC_Job_Query = 0x0017,	//���� 
		MAGIC_Job_Query_Resp = 0x8017,//���� 
		//�˺ż����ѯ
		MAGIC_Account_Active_Query = 0x0018,	//ͨ���˺Ų�ѯ
		MAGIC_Account_Active_Query_Resp = 0x8018,//ͨ���˺Ų�ѯ
		MAGIC_Sn_Active_Query  = 0x0019,		//ͨ���������ѯ
		MAGIC_Sn_Active_Query_Resp  = 0x8019,//ͨ���������ѯ
		//ϵͳ����
		MAGIC_Ban_Query = 0x0020,//����ѡ��ʱ�䷶Χ����������ɸѡ����ָ���������з��������Ľ�ɫ
		MAGIC_Ban_Query_Resp = 0x8020,//����ѡ��ʱ�䷶Χ����������ɸѡ����ָ���������з��������Ľ�ɫ
		MAGIC_Account_Ban_Query = 0x0021,//����ѡ��ʱ�䷶Χ���˺š��ǳƽ��в�ѯ����ʾ���˴���
		MAGIC_Account_Ban_Query_Resp = 0x8021,//����ѡ��ʱ�䷶Χ���˺š��ǳƽ��в�ѯ����ʾ���˴���
		
		//�ʺŵ�½��Ϣ
		MAGIC_Use_Query = 0x0022,	//�ʺŵ�½��Ϣ
		MAGIC_Use_Query_Resp = 0x8022,//�ʺŵ�½��Ϣ
		MAGIC_Account_Ip_Query = 0x0023,	//ͨ��IP��ַ��ѯ����½���ʺ�
		MAGIC_Account_Ip_Query_Resp = 0x8023,//ͨ��IP��ַ��ѯ����½���ʺ�
		MAGIC_Account_User_Query = 0x0024,	//ͨ���ʺŲ�ѯ��ʷ��½IP
		MAGIC_Account_User_Query_Resp = 0x8024,//ͨ���ʺŲ�ѯ��ʷ��½IP
		MAGIC_UseLog_Query = 0x0025,	//�ʼ���־��ѯ��Ϣ
		MAGIC_UseLog_Query_Resp = 0x8025,//�ʼ���־��ѯ��Ϣ

		//������
		//����
		MAGIC_Get_Item_Query = 0x0026,//��ȡ��Ϸ���ߣ����ࣩ
		MAGIC_Get_Item_Query_Resp = 0x8026,//��ȡ��Ϸ���ߣ����ࣩ
		MAGIC_Get_Item_Detail_Query = 0x0027,	//��ȡ��Ϸ���ߣ�С�ࣩ
		MAGIC_Get_Item_Detail_Query_Resp = 0x8027,	//��ȡ��Ϸ���ߣ�С�ࣩ
		MAGIC_Insert_Item_Query = 0x0047,//������Ϸ����
		MAGIC_Insert_Item_Query_Resp = 0x8047,//������Ϸ����
		
		//�˺�
		MAGIC_Account_Close = 0x0028,//��ͣ����ʺ�
		MAGIC_Account_Close_RESP = 0x8028,//��ͣ����ʺ���Ӧ
		MAGIC_Account_Open = 0x0029,//�������ʺ�
		MAGIC_Account_Open_RESP= 0x8030,//�������ʺ���Ӧ
		MAGIC_Account_BANISHMENT_QUERY = 0x0030,//��ҷ�ͣ�ʺŲ�ѯ״̬
		MAGIC_Account_BANISHMENT_QUERY_RESP = 0x8030,//��ҷ�ͣ�ʺŲ�ѯ״̬��Ӧ
		MAGIC_BanAccount_Query = 0x0031,//��ѯ���з�ͣ����ʺ���Ϣ
		MAGIC_BanAccount_Query_Resp = 0x8031,//��ѯ���з�ͣ����ʺ���Ϣ
		MAGIC_KickAccount_Query = 0x0032,//������
		MAGIC_KickAccount_Query_Resp = 0x8032,//������
	
		//��ͼ
		MAGIC_Change_Map_Query = 0x0033,//��ͼ����
		MAGIC_Change_Map_Query_Resp = 0x8033,//��ͼ����

		//����
		MAGIC_SendNote_Query = 0x0034,//���͹���
		MAGIC_SendNote_Query_Resp = 0x8034,//���͹���
		MAGIC_UpdateNote_Query = 0x0035,//�޸Ĺ���
		MAGIC_UpdateNote_Query_Resp= 0x8035,//�޸Ĺ���
		MAGIC_DeleteNote_Query = 0x0036,//ɾ������
		MAGIC_DeleteNote_Query_Resp= 0x8036,//ɾ������

		//��ɫ
		MAGIC_Update_Account_Query = 0x0037,//�޸Ľ�ɫ��Ϣ
		MAGIC_Update_Account_Query_Resp = 0x8037,//�޸Ľ�ɫ��Ϣ
		MAGIC_Update_Pet_Query = 0x0038,//�޸ĳ�����Ϣ
		MAGIC_Update_Pet_Query_Resp = 0x8038,//�޸ĳ�����Ϣ

		//����
		MAGIC_Insert_Account_Skill_Query = 0x0039,//���ӽ�ɫ������Ϣ
		MAGIC_Insert_Account_Skill_Query_Resp = 0x8039,//���ӽ�ɫ������Ϣ
		MAGIC_Insert_Pet_Skill_Query = 0x0040,//���ӳ��＼����Ϣ
		MAGIC_Insert_Pet_Skill_Query_Resp = 0x8040,//���ӳ��＼����Ϣ

		MAGIC_Update_Account_Skill_Query = 0x0041,//�޸Ľ�ɫ������Ϣ
		MAGIC_Update_Account_Skill_Query_Resp = 0x8041,//�޸Ľ�ɫ������Ϣ
		MAGIC_Update_Pet_Skilll_Query = 0x0042,//�޸ĳ��＼����Ϣ
		MAGIC_Update_Pet_Skill_Query_Resp = 0x8042,//�޸ĳ��＼����Ϣ

		MAGIC_Delete_Account_Skill_Query = 0x0043,//ɾ����ɫ������Ϣ
		MAGIC_Delete_Account_Skill_Query_Resp = 0x8043,//ɾ����ɫ������Ϣ
		MAGIC_Delete_Pet_Skill_Query = 0x0044,//ɾ�����＼����Ϣ
		MAGIC_Delete_Pet_Skill_Query_Resp = 0x8044,//ɾ�����＼����Ϣ

		//��ʱ�˺�
		MAGIC_Insert_TmpPwd_Query = 0x0045,//������ʱ����
		MAGIC_Insert_TmpPwd_Query_Resp = 0x8045,//������ʱ����
		MAGIC_Recover_TmpPwd_Query = 0x0046,//�ָ��û�����
		MAGIC_Recover_TmpPwd_Query_Resp = 0x8046,//�ָ��û�����
		Magic_MapList_Query = 0x0051,//��ѯ��ͼ�б�
		Magic_MapList_Query_Resp = 0x8051,//��ѯ��ͼ�б�
		MAGIC_SearchNote_Query = 0x0050,//�鿴����
		MAGIC_SearchNote_Query_Resp= 0x8050,//�鿴����

		Magic_SearchGuild_Query = 0x0052,//��ѯ������Ϣ
		Magic_SearchGuild_Query_Resp = 0x8052,//��ѯ������Ϣ

		Magic_SearchGuild_Detail_Query = 0x0053,//��ѯ������ϸ��Ϣ
		Magic_SearchGuild_Detail_Query_Resp = 0x8053,//��ѯ������ϸ��Ϣ

		Magic_CloseGuild_Query = 0x0054,//��ɢ����
		Magic_CloseGuild_Query_Resp = 0x8054,//��ɢ����

		Magic_RenameGuild_Query = 0x0055,//�޸Ĺ�������
		Magic_RenameGuild_Query_Resp = 0x8055,//�޸Ĺ�������

		Magic_Recovery_Account_Qurey = 0x0056,//�ָ���ɫ��Ϣ
		Magic_Recovery_Account_Qurey_Resp = 0x8056,//�ָ���ɫ��Ϣ

		Magic_Search_Account_Qurey = 0x0057,//��ѯ��ɫ����
		Magic_Search_Account_Qurey_Resp = 0x8057,//��ѯ��ɫ����

		Magic_BakAccount_Query = 0x0058,//��ѯ�����û�
		Magic_BakAccount_Query_Resp = 0x8058,//��ѯ�����û�
		
		//�����ʴ�ϵͳ
		Magic_SendAsk_Query = 0x0059,//�����ʴ�ϵͳ
		Magic_SendAsk_Query_Resp = 0x8059,//�����ʴ�ϵͳ

		//�޸Ľ�ɫ����
		Magic_UpdateAccount_Query = 0x0060,//�޸Ľ�ɫ����
		Magic_UpdateAccount_Query_Resp = 0x8060,//�޸Ľ�ɫ����

		//�޸Ľ�ɫ�ȼ�
		Magic_UpdateLevel_Query = 0x0061,//�޸Ľ�ɫ�ȼ�
		Magic_UpdateLevel_Query_Resp = 0x8061,//�޸Ľ�ɫ�ȼ�

		//�޸Ľ�ɫְҵ
		Magic_UpdateJob_Query = 0x0062,//�޸Ľ�ɫְҵ
		Magic_UpdateJob_Query_Resp = 0x8062,//�޸Ľ�ɫְҵ

		//��ȡ��ɫְҵ
		Magic_GetJob_Query = 0x0063,//��ȡ��ɫְҵ
		Magic_GetJob_Query_Resp = 0x8063,//��ȡ��ɫְҵ
		Magic_PackItem_Query = 0x0064,//����������Ϣ
		Magic_PackItem_Query_Resp = 0x8064,//����������Ϣ
		Magic_GetSkill_Query = 0x0065,//������＼������
		Magic_GerSkill_Query_Resp = 0x8065,//������＼������
		
		Magic_SkillList_Query = 0x0066,//������＼���б�
		Magic_SkillList_Query_Resp = 0x8066,//������＼���б�


		Magic_GetPetSkill_Query = 0x0067,//��ó��＼������
		Magic_GerPetSkill_Query_Resp = 0x8067,//��ó��＼������
		
		Magic_PetSkillList_Query = 0x0068,//��ó��＼���б�
		Magic_PetSkillList_Query_Resp = 0x8068,//��ó��＼���б�

		//�޸�����������Ϣ
		Magic_InsertBankItem_Query = 0x0069,//���е�������
		Magic_InsertBankItem_Query_Resp = 0x8069,//���е�������

		Magic_SetBankMoney_Query = 0x0070,//���н������
		Magic_SetBankMoney_Query_Resp = 0x8070,//���н������

		//�޸ĳ���������Ϣ
		Magic_ModiPetAttribute_Query = 0x0071,//�޸ĳ���������Ϣ
		Magic_ModiPetAttribute_Query_Resp = 0x8071,//

		Magic_PetList_Query = 0x0072,//��ȡ�����б�
		Magic_PetList_Query_Resp = 0x8072,//��ȡ�����б�

		Magic_AddPet_Query = 0x0073,//���ӳ���
		Magic_AddPet_Query_Resp = 0x8073,//���ӳ���
		//�ָ���־����
		Magic_LogItem_Query = 0x0074,//�鿴��־������Ϣ
		Magic_LogItem_Query_Resp = 0x8074,//�鿴��־������Ϣ

		Magic_RecoverLogItem_Query = 0x0075,//�ָ���־������Ϣ
		Magic_RecoverLogItem_Query_Resp = 0x8075,//�ָ���־������Ϣ

		Magic_Account_Teach_Query = 0x0076,//�鿴���ʦ����ϵ
		Magic_Account_Teach_Query_Resp = 0x8076,//�鿴���ʦ����ϵ

		Magic_Send_ItemPassword = 0x0077,//��ȡ������
		Magic_Send_ItemPassword_Resp = 0x8077,//��ȡ������

		Magic_SearchPassWord_Query = 0x0078,//��ѯ��ʱ����
		Magic_SearchPassWord_Query_Resp = 0x8078,//��ѯ��ʱ����

		MAGIC_InsertItemALL_Query = 0x0079,//���ӵ��ߣ����룩
		MAGIC_InsertItemALL_Query_Resp = 0x8079,//���ӵ��ߣ����룩

		Magic_UserShoppingInfo_Query = 0x0080,//�̳���Ϣ��ѯ
		Magic_UserShoppingInfo_Query_Resp = 0x8080,//�̳���Ϣ��ѯ

		Magic_UserGoldCard_Query = 0x0081,//�ƽ𼤻
		Magic_UserGoldCard_Query_Resp = 0x8081,//�ƽ𼤻

		MAGIC_InsertBankItemALL_Query = 0x0082,//�������е������ӣ����룩
		MAGIC_InsertBankItemALL_Query_Resp = 0x8082,//�������е������ӣ����룩

		Magic_SearchMap_Query = 0x0083,//ģ����ѯ��ͼ
		Magic_SearchMap_Query_Resp = 0x8083,//ģ����ѯ��ͼ

		Magic_PetPic_Query = 0x0084,//����ͼ����Ϣ
		Magic_PetPic_Query_Resp = 0x8084,//����ͼ����Ϣ

		Magic_UpdatePetLevel_Query = 0x0085,//�޸ĳ���ȼ�
		Magic_UpdatePetLevel_Query_Resp = 0x8085,//�޸ĳ���ȼ�

		MAGIC_BankPet_Query = 0x0086,//���г�����Ϣ
		MAGIC_BankPet_Query_Resp = 0x8086,//���г�����Ϣ

		Magic_UpdateGuildLv_Query=0x0087,//����ȼ��޸�
		Magic_UpdateGuildLv_Query_Resp=0x8087,//����ȼ��޸�

		Magic_UpdateGuildHonor_Query=0x0088,//���������޸�
		Magic_UpdateGuildHonor_Query_Resp=0x8088,//���������޸�

		Magic_LogInfo_Pet_Query = 0x0089,//������ϸ����
		Magic_LogInfo_Pet_Query_Resp = 0x8089,//������ϸ����

		Magic_LogInfo_Item_Query = 0x0090,//������ϸ����
		Magic_LogInfo_Item_Query_Resp = 0x8090,//������ϸ����

		Magic_AccountErr_Query = 0x0091,//����ȼ��쳣�ص�
		Magic_AccountErr_Query_Resp = 0x8091,//����ȼ��쳣�ص�

		Magic_ChangeGold_Query = 0x0092,//�޸�������Ǯ
		Magic_ChangeGold_Query_Resp = 0x8092,//�޸�������Ǯ

		Magic_BagItem_Del_Query = 0x0093,//ɾ����ɫ����������
		Magic_BagItem_Del_Query_Resp = 0x8093,//ɾ����ɫ����������

		Magic_TmpItem_Del_Query = 0x0094,//ɾ����ʱ����������
		Magic_TmpItem_Del_Query_Resp = 0x8094,//ɾ����ʱ����������

		Magic_EquipItem_Del_Query = 0x0095,//ɾ������װ������
		Magic_EquipItem_Del_Query_Resp = 0x8095,//ɾ������װ������

		Magic_BankItem_Del_Query = 0x0096,//ɾ�����е���
		Magic_BankItem_Del_Query_Resp = 0x8096,//ɾ�����е���

		Magic_PetPic_Del_Query = 0x0097,//ɾ�����е���
		Magic_PetPic_Del_Query_Resp = 0x8097,//ɾ�����е���

		Magic_KickAccountCount_Query = 0x0098,//�����ߴ���
		Magic_KickAccountCount_Query_Resp = 0x8098,//�����ߴ���

		Magic_RecoverLogPet_Query = 0x0099,//�ָ���־����
		Magic_RecoverLogPet_Query_Resp = 0x8099,//�ָ���־����

		#endregion
		#region ��������
		//��������
		Slq_PLAYER_INFO_Query=0x0001,// �鿴��һ�����Ϣ
		Slq_PLAYER_INFO_Query_Resp=0x8001,

		Slq_Char_INFO_Query=0x0002,// �鿴��ҽ�ɫ�Ļ�����Ϣ
		Slq_Char_INFO_Query_Resp=0x8002,

		Slq_KickPlayer_Query=0x0003,// ǿ����Ҷ���
		Slq_KickPlayer_Query_Resp=0x8003,

		Slq_BAN_PLAYER_Query=0x0004,// ��ͣ���
		Slq_BAN_PLAYER_Query_Resp=0x8004,

		Slq_POP_MSG_Query=0x0005,// ��������
		Slq_POP_MSG_Query_Resp=0x8005,
		Slq_Banuser_Query=0x0006,// ��ͣ��Ҳ�ѯ
		Slq_Banuser_Query_Resp=0x8006,
		Slq_RELEASEPLAYER_Query=0x0007,// ������
		Slq_RELEASEPLAYER_Query_Resp=0x8007,
		Slq_ItemInfo_Query = 0x0008,//��Ʒ��ѯ
		Slq_ItemInfo_Query_Resp = 0x8008,//��Ʒ��ѯ
		Slq_BuyInfo_Query = 0x0009,//���Ѽ�¼��ѯ
		Slq_BuyInfo_Query_Resp = 0x8009,//���Ѽ�¼��ѯ
		Slq_Login_Query = 0x0010,//�ʺŵ�½��־
		Slq_Login_Query_Resp = 0x8010,//�ʺŵ�½��־
		Slq_SkillInfo_Query = 0x0011,//�ʺŵ�½��־
		Slq_SkillInfo_Query_Resp = 0x8011,//�ʺŵ�½��־
		Slq_CHARACTER_INFO_OPERATION= 0x0012,//��ɫ����
		Slq_CHARACTER_INFO_OPERATION_Resp= 0x0012,//��ɫ����

		#endregion
		#region ����ONLINE
		LORD_Account_Query = 0x0001,//��һ�����Ϣ
		LORD_Account_Query_Resp = 0x8001,//��һ�����Ϣ
		LORD_HeroInfo_Query = 0x0002,//Ӣ����Ϣ
		LORD_HeroInfo_Query_Resp = 0x8002,//Ӣ����Ϣ
		LORD_LordInfo_Query = 0x0003,//������Ϣ
		LORD_LordInfo_Query_Resp = 0x8003,//������Ϣ
		LORD_LordHeroInfo_Query = 0x0004,//����Ӣ��
		LORD_LordHeroInfo_Query_Resp = 0x8004,//����Ӣ��
		LORD_LordInfo_Detail_Query = 0x0005,//������ϸ��Ϣ
		LORD_LordInfo_Detail_Query_Resp = 0x8005,//������ϸ��Ϣ
		LORD_AttackInfo_Query = 0x0006,//ս�� ----��������
		LORD_AttackInfo_Query_Resp = 0x8006,//ս�� ----��������
		LORD_Resources_Change_Query = 0x0007,//��Դ����
		LORD_Resources_Change_Query_Resp  = 0x8007,//��Դ����
		LORD_Information_Query = 0x0008,//����
		LORD_Information_Query_Resp = 0x8008,//����
		LORD_Famine_Query = 0x0009,//����
		LORD_Famine_Query_Resp = 0x8009,//����
		LORD_Search_Query = 0x0010,//̽��
		LORD_Search_Query_Resp = 0x8010,//̽��

		
		LORD_BuildInfo_Query = 0x0011,//��������Ϣ
		LORD_BuildInfo_Query_Resp = 0x8011,//��������Ϣ
		LORD_AmyLord_Query = 0x0012,//פ������
		LORD_AmyLord_Query_Resp = 0x8012,//פ������
		LORD_Expedition_Query = 0x0013,//����������Ϣ
		LORD_Expedition_Query_Resp = 0x8013,//����������Ϣ
		LORD_Reinforce_Query = 0x0014,//��Ԯ��Ϣ
		LORD_Reinforce_Query_Resp = 0x8014,//��Ԯ��Ϣ
		LORD_Military_Action_Query = 0x0015,//���»��¼
		LORD_Military_Action_Query_Resp = 0x8015,//���»��¼
		LORD_Hero_Log_Query = 0x0016,//Ӣ�ۼ�¼
		LORD_Hero_Log_Query_Resp = 0x8016,//Ӣ�ۼ�¼
		LORD_ItemList_Query = 0x0017,//�����б�
		LORD_ItemList_Query_Resp = 0x8017,//�����б�
		LORD_GetItem_Query = 0x0018,//���߻�ü�¼
		LORD_GetItem_Query_Resp = 0x8018,//���߻�ü�¼
		LORD_UserItem_Query = 0x0019,//����ʹ�ü�¼
		LORD_UserItem_Query_Resp = 0x8019,//����ʹ�ü�¼
		LORD_FixItem_Query = 0x0020,//����������¼
		LORD_FixItem_Query_Resp = 0x8020,//����������¼
		LORD_SetTroop_Query = 0x0021,//���ñ�������
		LORD_SetTroop_Query_Resp = 0x8021,//���ñ�������
		LORD_RestoreHero_Query = 0x0022,//Ӣ���һ�
		LORD_RestoreHero_Query_Resp = 0x8022,//Ӣ���һ�
		LORD_AddItem_Query = 0x0023,//���ӵ�������
		LORD_AddItem_Query_Resp = 0x8023,//���ӵ�������
		LORD_AddResource_Query = 0x0024,//������Դ������Ϊ����
		LORD_AddResource_Query_Resp = 0x8024,//������Դ������Ϊ����

		LORD_Soldier_Query = 0x0025,//����
		LORD_Soldier_Query_Resp = 0x8025,//����
		LORD_Soldier_Train_Query = 0x0026,//ʿ��ѵ����¼
		LORD_Soldier_Train_Query_Resp = 0x8026,//ʿ��ѵ����¼

		LORD_BuildLog_Query = 0x0027,//������¼
		LORD_BuildLog_Query_Resp = 0x8027,//������¼
		LORD_ItemBox_Query = 0x0028,//�������еĵ���
		LORD_ItemBox_Query_Resp = 0x8028,//�������еĵ���
		LORD_ComposeBox_Query = 0x0029,//�ϳ����еĵ���
		LORD_ComposeBox_Query_Resp = 0x8029,//�ϳ����еĵ���
		LORD_Set_Resource_Query = 0x0030,//��ȡ��Դ�б�
		LORD_Set_Resource_Query_Resp = 0x8030,//��ȡ��Դ�б�

		LORD_DefenseInfo_Query = 0x0031,//ս�� ----���ܹ���
		LORD_DefenseInfo_Query_Resp = 0x8031,//ս�� ----���ܹ���
		LORD_Identified_Query = 0x0032,//���߱�ʶ��¼
		LORD_Identified_Query_Resp = 0x8032,//���߱�ʶ��¼
		LORD_Troop_Query = 0x0033,//������Ϣ
		LORD_Troop_Query_Resp = 0x8033,//������Ϣ
		LORD_SendNotes_Query = 0x0034,//���͹���
		LORD_SendNotes_Query_Resp = 0x8034,//���͹���
		LORD_SetVip_Query = 0x0035,//����VIP
		LORD_SetVip_Query_Resp = 0x8035,//����VIP
		LORD_Kick_Query = 0x0036,//����
		LORD_Kick_Query_Resp = 0x8036,//����
		LORD_BackHp_Query = 0x0037,//Ӣ�ۻ�Ѫ
		LORD_BackHp_Query_Resp = 0x8037,//Ӣ�ۻ�Ѫ
		LORD_BackLife_Query = 0x0038,//Ӣ�۸���
		LORD_BackLife_Query_Resp = 0x8038,//Ӣ�۸���
		LORD_BanAccount_Query = 0x0039,//��ͣ
		LORD_BanAccount_Query_Resp = 0x8039,//��ͣ
		LORD_Resource_Query = 0x0040,//��Դ�б�
		LORD_Resource_Query_Resp = 0x8040,//��Դ�б�
		LORD_SearchBan_Query = 0x0041,//��ѯ��ͣ�û�
		LORD_SearchBan_Query_Resp = 0x8041,//��ѯ��ͣ�û�
		LORD_NoteList_Query = 0x0042,//�����б�
		LORD_NoteList_Query_Resp = 0x8042,//�����б�


		SanGo_Account_Query = 0x0001,//��һ�����Ϣ
		SanGo_Account_Query_Resp=0x8001,//��һ�����Ϣ
		SanGo_Cityinfo_Query=0x0002,//���л�����Ϣ
		SanGo_Cityinfo_Query_Resp=0x8002,//���л�����Ϣ
		SanGo_buildinginfo_Query=0x0003,//���н����������Ϣ
		SanGo_buildinginfo_Query_Resp=0x8003,//���н����������Ϣ
		SanGo_heroinfo_Query=0x0004,//�佫��Ϣ
		SanGo_heroinfo_Query_Resp=0x8004,//�佫��Ϣ
		SanGo_armyinfo_Query=0x0005,//���ֻ�����Ϣ
		SanGo_armyinfo_Query_Resp=0x8005,//���ֻ�����Ϣ
		SanGo_armydoinfo_Query=0x0006,//���ֵ�����Ϣ
		SanGo_armydoinfo_Query_Resp=0x8006,//���ֵ�����Ϣ
		SanGo_transportdoinfo_Query=0x0007,//�̶���Ϣ
		SanGo_transportdoinfo_Query_Resp=0x8007,//�̶���Ϣ
		SanGo_BuildingLogInfo_Query=0x0008,//���������log��Ϣ
		SanGo_BuildingLogInf_Queryo_Resp=0x8008,//���������log��Ϣ
		SanGo_TrinArmyLogInfo_Query=0x0009,//����ѵ��log��Ϣ
		SanGo_TrinArmyLogInfo_Query_Resp=0x8009,//����ѵ��log��Ϣ
		SanGo_ScienceInfo_Query=0x0010,//�Ƽ���Ϣ��ѯ
		SanGo_ScienceInfo_Query_Resp=0x8010,//�Ƽ���Ϣ��
		SanGo_Playiteminfo_Query= 0x0011,//�����¼
		SanGo_Playiteminfo_Query_Resp= 0x8011,//�����¼
		SanGo_PlayUseiteminfo_Query= 0x0012,//ʹ�õ��߼�¼
		SanGo_PlayUseiteminfo_Query_Resp= 0x8012,//ʹ�õ��߼�¼
		SanGo_Playitemcome_Query= 0x0013,//���߻�ü�¼
		SanGo_Playitemcome_Query_Resp= 0x8013,//���߻�ü�¼
		SanGo_Playpayment_Query= 0x0014,//��ֵ��¼
		SanGo_Playpayment_Query_Resp= 0x8014,//��ֵ��¼
		SanGo_ActivecodeItem_Query= 0x0015,//��������߲�ѯ
		SanGo_ActivecodeItem_Query_Resp= 0x8015,//��������߲�ѯ
		SanGo_Userexchangeitems_Query= 0x0016,//�û����ֶһ����߲�ѯ
		SanGo_Userexchangeitems_Query_Resp= 0x8016,//�û����ֶһ����߲�ѯ
		SanGo_Userexshiwuitem_Query= 0x0017,//�û����ֶһ�ʵ���ѯ
		SanGo_Userexshiwuitem_Query_Resp= 0x8017,//�û����ֶһ�ʵ���ѯ
		SanGo_Userlogin_Query= 0x0018,//�û���¼��ѯ
		SanGo_Userlogin_Query_Resp= 0x8018,//�û���¼��ѯ
		SanGo_Userpoints_Query= 0x0019,//�û����ֲ�ѯ
		SanGo_Userpoints_Query_Resp= 0x8019,//�û����ֲ�ѯ
		SanGo_Sysbuyinfo_Query=0x0020,//ϵͳ�̵깺����Ϣ��ѯ
		SanGo_Sysbuyinfo_Query_Resp=0x8020,//ϵͳ�̵깺����Ϣ��ѯ
		SanGo_Sysmoneyinfo_Query=0x0021,//���ʹ�ü�¼��ѯ
		SanGo_Sysmoneyinfo_Query_Resp=0x8021,//���ʹ�ü�¼��ѯ
		#endregion
		#region �ɽ�ONLINE
		Pal_UserLogininfo_Query= 0x0001,//�û���½��¼
		Pal_UserLogininfo_Query_Resp= 0x8001,//�û���½��¼
		Pal_UserBan_Query= 0x0002,//��ͣ�û���ѯ
		Pal_UserBan_Query_Resp= 0x8002,//��ͣ�û���ѯ
		Pal_UserBan_Insert= 0x0003,//��ͣ�û�
		Pal_UserBan_Insert_Resp= 0x8003,//��ͣ�û�
		Pal_UserBan_Del= 0x0004,//����û�
		Pal_UserBan_Del_Resp= 0x8004,//����û�
		Pal_UserBan_AllQuery= 0x0005,//�ô������з�ͣ�û���ѯ
		Pal_UserBan_AllQuery_Resp= 0x8005,//�ô������з�ͣ�û���ѯ
		Pal_bulletin_Query = 0x0006,
		Pal_bulletin_Query_Resp = 0x8006,
		Pal_bulletin_Insert = 0x0007,
		Pal_bulletin_Insert_Resp = 0x8007,
		Pal_bulletin_Update = 0x0008,
		Pal_bulletin_Update_Resp = 0x8008,
		Pal_BoardTask_OwnerQuery = 0x0009,
		Pal_BoardTask_OwnerQuery_Resp = 0x8009,
		Pal_Playerinfo_Query= 0x0010,//�û�����������Ϣ
		Pal_Playerinfo_Query_Resp= 0x8010,//�û�����������Ϣ
		Pal_PlayerPackinfo_Query= 0x0011,//�û�����������Ϣ
		Pal_PlayerPackinfo_Query_Resp= 0x8011,//�û�����������Ϣ
		Pal_PlayerTaskinfo_Query= 0x0012,//��ɫ������Ϣ
		Pal_PlayerTaskinfo_Query_Resp= 0x8012,//��ɫ������Ϣ
		Pal_PlayerFriendlist_Query= 0x0013,//��ɫ������Ϣ
		Pal_PlayerFriendlist_Query_Resp= 0x8013,//��ɫ������Ϣ
		Pal_KickPlayer_Query= 0x0014,//��������
		Pal_KickPlayer_Query_Resp= 0x8014,//��������
		Pal_UserAccount_Active_Query = 0x0015,//�����˺Ų�ѯ
		Pal_UserAccount_Active_Query_Resp = 0x8015,//�����˺Ų�ѯ

		Pal_UserAccount_Cdk_Query = 0x0016,//���ݼ������ѯ
		Pal_UserAccount_Cdk_Query_Resp = 0x8016,//���ݼ������ѯ
		#endregion

		#region ������II
		JW2_ACCOUNT_QUERY = 0x0001,//����ʺ���Ϣ��ѯ��1.2.3.4.5.8��
		JW2_ACCOUNT_QUERY_RESP = 0x8001,//����ʺ���Ϣ��ѯ��Ӧ��1.2.3.4.5.8��
		JW2_ACCOUNTREMOTE_QUERY = 0x0002,//��Ϸ��������ͣ������ʺŲ�ѯ
		JW2_ACCOUNTREMOTE_QUERY_RESP = 0x8002,//��Ϸ��������ͣ������ʺŲ�ѯ��Ӧ
		JW2_ACCOUNTLOCAL_QUERY = 0x0003,//���ط�ͣ������ʺŲ�ѯ
		JW2_ACCOUNTLOCAL_QUERY_RESP = 0x8003,//���ط�ͣ������ʺŲ�ѯ��Ӧ
		JW2_ACCOUNT_CLOSE = 0x0004,//��ͣ������ʺ�
		JW2_ACCOUNT_CLOSE_RESP = 0x8004,//��ͣ������ʺ���Ӧ
		JW2_ACCOUNT_OPEN = 0x0005,//��������ʺ�
		JW2_ACCOUNT_OPEN_RESP = 0x8005,//��������ʺ���Ӧ
		JW2_ACCOUNT_BANISHMENT_QUERY = 0x0006,//��ҷ�ͣ�ʺŲ�ѯ
		JW2_ACCOUNT_BANISHMENT_QUERY_RESP = 0x8006,//��ҷ�ͣ�ʺŲ�ѯ��Ӧ
		JW2_BANISHPLAYER=0x0007,//����
		JW2_BANISHPLAYER_RESP=0x8007,//������Ӧ
		JW2_BOARDMESSAGE=0x0008,//����
		JW2_BOARDMESSAGE_RESP=0x8008,//������Ӧ
			
		JW2_LOGINOUT_QUERY=0x0009,//����������/�ǳ���Ϣ
		JW2_LOGINOUT_QUERY_RESP=0x8009,//����������/�ǳ���Ϣ��Ӧ

		JW2_RPG_QUERY=0x0010,//��ѯ������ڣ�6��
		JW2_RPG_QUERY_RESP=0x8010,//��ѯ���������Ӧ��6��
					
		JW2_ITEMSHOP_BYOWNER_QUERY = 0x0011,////�鿴������ϵ�����Ϣ��7��7��
		JW2_ITEMSHOP_BYOWNER_QUERY_RESP = 0x8011,////�鿴������ϵ�����Ϣ��Ӧ��7��7��
			
			
		JW2_DUMMONEY_QUERY = 0x0012,////��ѯ����������ң�7��8��
		JW2_DUMMONEY_QUERY_RESP = 0x8012,////��ѯ�������������Ӧ��7��8��
		JW2_HOME_ITEM_QUERY = 0x0013,////�鿴������Ʒ�嵥�����ޣ�7��9��
		JW2_HOME_ITEM_QUERY_RESP = 0x8013,////�鿴������Ʒ�嵥��������Ӧ��7��9��
		JW2_SMALL_PRESENT_QUERY = 0x0014,////�鿴�������7��10��
		JW2_SMALL_PRESENT_QUERY_RESP = 0x8014,////�鿴���������Ӧ��7��10��
		JW2_WASTE_ITEM_QUERY = 0x0015,////�鿴�����Ե��ߣ�7��11��
		JW2_WASTE_ITEM_QUERY_RESP = 0x8015,////�鿴�����Ե�����Ӧ��7��11��
		JW2_SMALL_BUGLE_QUERY = 0x0016,////�鿴С���ȣ�7��12��
		JW2_SMALL_BUGLE_QUERY_RESP  = 0x8016,////�鿴С������Ӧ��7��12��
			
			
			
		JW2_WEDDINGINFO_QUERY=0x0017,//������Ϣ
		JW2_WEDDINGINFO_QUERY_RESP=0x8017,
		JW2_WEDDINGLOG_QUERY=0x0018,//������ʷ
		JW2_WEDDINGLOG_QUERY_RESP=0x8018,
		JW2_WEDDINGGROUND_QUERY=0x0019,//�����Ϣ
		JW2_WEDDINGGROUND_QUERY_RESP=0x8019,
		JW2_COUPLEINFO_QUERY=0x0020,//������Ϣ
		JW2_COUPLEINFO_QUERY_RESP=0x8020,
		JW2_COUPLELOG_QUERY=0x0021,//������ʷ
		JW2_COUPLELOG_QUERY_RESP=0x8021,
			
		
		JW2_FAMILYINFO_QUERY=0x0022,//������Ϣ
		JW2_FAMILYINFO_QUERY_RESP=0x8022,
		JW2_FAMILYMEMBER_QUERY=0x0023,//�����Ա��Ϣ
		JW2_FAMILYMEMBER_QUERY_RESP=0x8023,
		JW2_SHOP_QUERY=0x0024,//�̳���Ϣ
		JW2_SHOP_QUERY_RESP=0x8024,

			
		JW2_User_Family_Query=0x0025,//�û�������Ϣ
		JW2_User_Family_Query_Resp=0x8025,

		JW2_FamilyItemInfo_Query=0x0026,//���������Ϣ
		JW2_FamilyItemInfo_Query_Resp=0x8026,
			
		JW2_FamilyBuyLog_Query=0x0027,//���幺����־
		JW2_FamilyBuyLog_Query_Resp=0x8027,
			
		JW2_FamilyTransfer_Query=0x0028,//����ת����Ϣ
		JW2_FamilyTransfer_Query_Resp=0x8028,

		JW2_FriendList_Query=0x0029,//�����б�
		JW2_FriendList_Query_Resp=0x8029,


		JW2_BasicInfo_Query=0x0030,//������Ϣ��ѯ
		JW2_BasicInfo_Query_Resp=0x8030,

		JW2_FamilyMember_Applying=0x0031,//�����г�Ա
		JW2_FamilyMember_Applying_Resp=0x8031,
			
		JW2_BasicRank_Query=0x0032,//���صȼ�
		JW2_BasicBank_Query_Resp=0x8032,

		///////////����////////////////////////////
		JW2_BOARDTASK_INSERT = 0x0033,//��������
		JW2_BOARDTASK_INSERT_RESP = 0x8033,//����������Ӧ
		JW2_BOARDTASK_QUERY = 0x0034,//�����ѯ
		JW2_BOARDTASK_QUERY_RESP = 0x8034,//�����ѯ��Ӧ
		JW2_BOARDTASK_UPDATE = 0x0035,//�������
		JW2_BOARDTASK_UPDATE_RESP = 0x8035,//���������Ӧ

		JW2_ITEM_DEL=0x0036,//����ɾ��������0����Ʒ��1�����2��
		JW2_ITEM_DEL_RESP=0x8036,//����ɾ��������0����Ʒ��1�����2��

		JW2_MODIFYSEX_QUREY=0x0037,//�޸Ľ�ɫ�Ա�
		JW2_MODIFYSEX_QUEYR_RESP=0x8037,

		JW2_MODIFYLEVEL_QUERY=0x0038,//�޸ĵȼ�
		JW2_MODIFYLEVEL_QUERY_RESP=0x8038,

		JW2_MODIFYEXP_QUERY=0x0039,//�޸ľ���
		JW2_MODIFYEXP_QUERY_RESP=0x8039,
			
		JW2_BAN_BIGBUGLE=0x0040,//���ô�����
		JW2_BAN_BIGBUGLE_RESP=0x8040,

		JW2_BAN_SMALLBUGLE=0x0041,//����С����
		JW2_BAN_SMALLBUGLE_RESP=0x8041,

		JW2_DEL_CHARACTER=0x0042,//ɾ����ɫ
		JW2_DEL_CHARACTER_RESP=0x8042,
			
		JW2_RECALL_CHARACTER=0x0043,//�ָ���ɫ
		JW2_RECALL_CHARACTER_RESP=0x8043,
			
		JW2_MODIFY_MONEY=0x0044,//�޸Ľ�Ǯ
		JW2_MODIFY_MONEY_RESP=0x8044,

		JW2_ADD_ITEM=0x0045,//���ӵ���
		JW2_ADD_ITEM_RESP=0x8045,

		JW2_CREATE_GM=0x0046,//ÿ����������GM
		JW2_CREATE_GM_RESP=0x8046,

		JW2_MODIFY_PWD=0x0047,//�޸�����
		JW2_MODIFY_PWD_RESP=0x8047,

		JW2_RECALL_PWD=0x0048,//�ָ�����
		JW2_RECALL_PWD_RESP=0x8048,

		JW2_ItemInfo_Query=0x0049,//���߲�ѯ
		JW2_ItemInfo_Query_Resp=0x8049,//

			
		JW2_ITEM_SELECT=0x0050,//����ģ����ѯ
		JW2_ITEM_SELECT_RESP=0x8050,//

		JW2_PetInfo_Query=0x0051,//������Ϣ
		JW2_PetInfo_Query_Resp=0x8051,
		
		JW2_Messenger_Query=0x0052,//�ƺŲ�ѯ
		JW2_Messenger_Query_Resp=0x8052,

		JW2_Wedding_Paper=0x0053,//���֤��
		JW2_Wedding_Paper_Resp=0x8053,

		JW2_CoupleParty_Card=0x0054,//�����ɶԿ�
		JW2_CoupleParty_Card_Resp=0x8054,


		JW2_MailInfo_Query=0x0055,//ֽ����Ϣ
		JW2_MailInfo_Query_Resp=0x8055,

		JW2_MoneyLog_Query=0x0056,//��Ǯ��־��ѯ
		JW2_MoneyLog_Query_Resp=0x8056,

		JW2_FamilyFund_Log=0x0057,//������־
		JW2_FamilyFund_Log_Resp=0x8057,

		JW2_FamilyItem_Log=0x0058,//���������־
		JW2_FamilyItem_Log_Resp=0x8058,

		JW2_Item_Log=0x0059,//������־
		JW2_Item_Log_Resp=0x8059,

		JW2_ADD_ITEM_ALL=0x0060,//���ӵ���(����)
		JW2_ADD_ITEM_ALL_RESP=0x8060,

		JW2_CashMoney_Log=0x0061,//������־
		JW2_CashMoney_Log_Resp=0x8061,

		JW2_SearchPassWord_Query = 0x0062,//��ѯ��ʱ����
		JW2_SearchPassWord_Query_Resp = 0x8062,//��ѯ��ʱ����

		JW2_CenterAvAtarItem_Bag_Query = 0x0063,//�м䱳������
		JW2_CenterAvAtarItem_Bag_Query_Resp = 0x8063,//�м䱳������

		JW2_CenterAvAtarItem_Equip_Query = 0x0064,//�м����ϵ���
		JW2_CenterAvAtarItem_Equip_Query_Resp = 0x8064,//�м����ϵ���

		JW2_House_Query = 0x0065,//С����
		JW2_House_Query_Resp = 0x8065,//С����

		JW2_GM_Update = 0x0066,//GM��B�޸�
		JW2_GM_Update_Resp = 0x8066,//GM��B�޸�

		JW2_JB_Query = 0x0067,//�e����Ϣ��ԃ
		JW2_JB_Query_Resp = 0x8067,//�e����Ϣ��ԃ

		JW2_UpDateFamilyName_Query = 0x0068,//�޸ļ�����
		JW2_UpDateFamilyName_Query_Resp = 0x8068,//�޸ļ�����

		JW2_UpdatePetName_Query = 0x0069,//�޸Č�����
		JW2_UpdatePetName_Query_Resp = 0x8069,//�޸Č�����

		JW2_Act_Card_Query = 0x0070,//�����ѯ
		JW2_Act_Card_Query_Resp = 0x8070,//�����ѯ

		JW2_Center_Kick_Query = 0x0071,//���g������
		JW2_Center_Kick_Query_Resp = 0x8071,//���g������

		JW2_ChangeServerExp_Query = 0x0072,//�޸ķ�������򞱶��
		JW2_ChangeServerExp_Query_Resp = 0x8072,//�޸ķ�������򞱶��

		JW2_ChangeServerMoney_Query = 0x0073,//�޸ķ�������Ǯ����
		JW2_ChangeServerMoney_Query_Resp = 0x8073,//�޸ķ�������Ǯ����

		JW2_MissionInfoLog_Query = 0x0074,//����LOG��ѯ
		JW2_MissionInfoLog_Query_Resp = 0x8074,//����LOG��ѯ

		JW2_AgainBuy_Query = 0x0075,//�ظ������˿�
		JW2_AgainBuy_Query_Resp = 0x8075,//�ظ������˿�

		JW2_GSSvererList_Query = 0x0076,//�������б�GS
		JW2_GSSvererList_Query_Resp = 0x8076,//�������б�GS

		JW2_Materiallist_Query = 0x0079,//�Ñ��ϳɲ��ϲ�ѯ
		JW2_Materiallist_Query_Resp = 0x8079,//�Ñ��ϳɲ��ϲ�ѯ

		JW2_MaterialHistory_Query = 0x0080,//�Ñ��ϳɼ�¼
		JW2_MaterialHistory_Query_Resp = 0x8080,//�Ñ��ϳɼ�¼


		JW2_ACTIVEPOINT_QUERY=0x0081,//��Ծ�Ȳ�ѯ	
		JW2_ACTIVEPOINT_QUERY_Resp=0x8081,//��Ծ�Ȳ�ѯ

		JW2_GETPIC_Query = 0x0082,//�����Ҫ��˵�ͼƬ�б�
		JW2_GETPIC_Query_Resp = 0x8082,//�����Ҫ��˵�ͼƬ�б�

		JW2_CHKPIC_Query = 0x0083,//���ͼƬ 2���ͨ����3��˲�ͨ�� 
		JW2_CHKPIC_Query_Resp = 0x8083,//���ͼƬ 2���ͨ����3��˲�ͨ��

		JW2_PicCard_Query = 0x0084,//�DƬ�ς���ʹ��
		JW2_PicCard_Query_Resp = 0x8084,//�DƬ�ς���ʹ��

		JW2_FamilyPet_Query = 0x0085,//�������
		JW2_FamilyPet_Query_Resp = 0x8085,//��������ѯ


		JW2_BuyPetAgg_Query = 0x0086,//�峤������ﵰ��ѯ
		JW2_BuyPetAgg_Query_Resp = 0x8086,//�峤������ﵰ��ѯ

		JW2_PetFirend_Query = 0x0087,//������ｻ�Ѳ�ѯ
		JW2_PetFirend_Query_Resp = 0x8087,//������ｻ�Ѳ�ѯ

		JW2_SmallPetAgg_Query = 0x0088,//�����Ա��ȡС������Ϣ��ѯ
		JW2_SmallPetAgg_Query_Resp = 0x8088,//�����Ա��ȡС������Ϣ��ѯ
		#endregion
		ERROR = 0xFFFF
	}


	/// <summary>
	/// Packet_Head ��ժҪ˵����
	/// </summary>
	public class Packet_Head
	{
		/// <summary>
		/// ��Ϣ����󳤶�
		/// </summary>
		public const uint HEAD_LENGTH = 16;
		/// <summary>
		/// ��Ϣ��byte����
		/// </summary>
		public byte[] m_bHeadBuffer;
		/// <summary>
		/// ��Ϣ��byte���鳤��
		/// </summary>
		public uint m_uiHeadBufferLen = HEAD_LENGTH;
		/// <summary>
		/// ��Ϣ���к�ID
		/// </summary>
		public uint m_uiSeqID;
		/// <summary>
		/// ��Ϣ����
		/// </summary>
		public Msg_Category m_mcCategory;
		/// <summary>
		/// ��Ϣ����
		/// </summary>
		public ServiceKey m_skServiceKey;
		/// <summary>
		/// ��Ϣ����������
		/// </summary>
		public DateTime m_dtMsgDateTime;
		/// <summary>
		/// ��Ϣ�峤��
		/// </summary>
		public uint m_uiBodyLen;
		/// <summary>
		/// �Ƿ��ǺϷ���Ϣͷ
		/// </summary>
		public bool IsValidHead = false;

		public Packet_Head()
		{
		}
		/// <summary>
		/// ������Ϣͷ
		/// </summary>
		/// <param name="uiSeqID">��Ϣ���к�</param>
		/// <param name="mcCategory">��Ϣ����</param>
		/// <param name="skServiceKey">��Ϣ����</param>
		/// <param name="uiBodyLen">��Ϣ�峤��</param>
		public Packet_Head(uint uiSeqID, Msg_Category mcCategory,ServiceKey skServiceKey, uint uiBodyLen ) 
		{
			this.m_uiSeqID = uiSeqID;
			this.m_mcCategory = mcCategory;
			this.m_skServiceKey = skServiceKey;
			this.m_dtMsgDateTime = System.DateTime.Now;
			this.m_uiBodyLen = uiBodyLen;

			this.IsValidHead = this.PutToBuffer();
		}
		/// <summary>
		/// ��װ��Ϣͷ����Ϣͷ�������кš���Ϣ����(CateGory)����Ϣ����(ServiceKey)������
		/// </summary>
		/// <returns></returns>
		private bool PutToBuffer()
		{
			this.m_bHeadBuffer = new byte[HEAD_LENGTH];
			// sequence id
			for ( int i = 3;i >= 0;i-- ) 
			{
				m_bHeadBuffer[ i ] = (byte) (m_uiSeqID >> ( 8 * i )) ;
			}
			// msg category
			m_bHeadBuffer[ 4 ] = ( byte ) m_mcCategory;
			// reserved
			m_bHeadBuffer[ 5 ] = 0;
			// service key
			for ( int i = 1;i >= 0;i-- ) 
			{
				m_bHeadBuffer[ 6 + i ] = ( byte ) ( ((ushort)m_skServiceKey) >> ( 8 * i ) );
			}			
			m_bHeadBuffer[ 8 ] = ( byte ) ( m_dtMsgDateTime.Year - 1900);
			m_bHeadBuffer[ 9 ] = ( byte ) ( m_dtMsgDateTime.Month );
			m_bHeadBuffer[ 10 ] = ( byte ) ( m_dtMsgDateTime.Day );
			m_bHeadBuffer[ 11 ] = ( byte ) ( m_dtMsgDateTime.Hour );
			m_bHeadBuffer[ 12 ] = ( byte ) ( m_dtMsgDateTime.Minute );
			m_bHeadBuffer[ 13 ] = ( byte ) ( m_dtMsgDateTime.Second );
			// Body len
			for ( int i = 1;i >= 0;i-- ) 
			{
				m_bHeadBuffer[ 14 + i ] = ( byte ) ( m_uiBodyLen >> ( 8 * i ) );
			}
			return true;
		}
        /// <summary>
        /// ������Ϣͷ
        /// </summary>
        /// <param name="bHeadBuffer">��Ϣͷ</param>
        /// <param name="uiHeadBufferLen">��Ϣͷ����</param>
		public Packet_Head(byte[] bHeadBuffer, uint uiHeadBufferLen )
		{
			if (bHeadBuffer == null || bHeadBuffer.Length < HEAD_LENGTH)
				return ;
			//this.m_uiHeadBufferLen = uiHeadBufferLen;
			this.m_bHeadBuffer = new byte[this.m_uiHeadBufferLen];
			System.Array.Copy(bHeadBuffer,0,m_bHeadBuffer,0,m_uiHeadBufferLen);

			this.IsValidHead = this.Init();
		}
        /// <summary>
        /// ��ʼ����Ϣͷ
        /// </summary>
        /// <returns></returns>
		
		private bool Init()
		{
			if (!this.IsValidHeadBuffer())
				return false;
			if (!this.getSequenceID(ref this.m_uiSeqID))
				return false;
			if (!this.getMsgCategory(ref this.m_mcCategory))
				return false;
			if (!this.getSeriveKey(ref this.m_skServiceKey))
				return false;
			if (!this.getMsgDateTime(ref this.m_dtMsgDateTime))
				return false;
			if (!this.getPacketBodyLen(ref this.m_uiBodyLen))
				return false;
			return true;
		}
		private bool IsValidHeadBuffer()
		{
			if ( this.m_bHeadBuffer == null || this.m_bHeadBuffer.Length != HEAD_LENGTH || this.m_uiHeadBufferLen != HEAD_LENGTH)
				return false;
			return true;
		}
        /// <summary>
        /// �õ���Ϣ���к�
        /// </summary>
        /// <param name="seqid">���к�</param>
        /// <returns></returns>
		private bool getSequenceID(ref uint seqid) //ByteArrayToUInt()
		{
			if (!this.IsValidHeadBuffer())
				return false;

			byte[] temp = new byte[ 4 ];
			System.Array.Copy(this.m_bHeadBuffer,0,temp,0,4);
			seqid = charArrayToInt( temp, 4 );
			return true;
		}
		/// <summary>
		/// �õ���Ϣ����
		/// </summary>
		/// <param name="mc">��Ϣ����</param>
		/// <returns></returns>
		private bool getMsgCategory(ref Msg_Category mc) 
		{
			if (!this.IsValidHeadBuffer())
				return false;
			try
			{
				mc = (Msg_Category) this.m_bHeadBuffer[4];
				return true;
			}
			catch(System.Exception)
			{
				mc = Msg_Category.ERROR;
				return false;
			}
		}
        /// <summary>
        /// ��Ϣ����
        /// </summary>
        /// <param name="sk">����</param>
        /// <returns></returns>
		private bool getSeriveKey(ref ServiceKey sk)//test(ServiceKey_FeeRequest)(temp[0] + temp[1] << 8) 
		{
			if (!this.IsValidHeadBuffer())
				return false;

			byte[] temp = new byte[ 2 ];
			System.Array.Copy(this.m_bHeadBuffer,6,temp,0,2);
			try
			{
				sk = (ServiceKey)((ushort)temp[0] + (ushort)(temp[1] << 8));
				return true;
			}
			catch(System.Exception)
			{
				sk = ServiceKey.ERROR;
				return false;
			}
		}
		/// <summary>
		/// �õ���Ϣ����
		/// </summary>
		/// <param name="dt">��������</param>
		/// <returns></returns>
		private bool getMsgDateTime(ref DateTime dt ) 
		{
			if (!this.IsValidHeadBuffer())
				return false;

			uint year = ( uint ) this.m_bHeadBuffer[ 8 ] + 1900;
			uint month = ( uint ) this.m_bHeadBuffer[ 9 ];
			uint day = ( uint ) this.m_bHeadBuffer[ 10 ];
			uint hour = (uint)this.m_bHeadBuffer[11];
			uint minute = (uint)this.m_bHeadBuffer[12];
			uint second = (uint)this.m_bHeadBuffer[13];

			try
			{
				dt = new DateTime((int)year,(int)month,(int)day,(int)hour,(int)minute,(int)second);
				return true;
			}
			catch(System.Exception)
			{
				dt = new DateTime();
				return false;
			}			
		}
        /// <summary>
        /// �õ���Ϣ�峤��
        /// </summary>
        /// <param name="len">��Ϣ�峤��</param>
        /// <returns></returns>
		private bool getPacketBodyLen(ref uint len) 
		{
			if (!this.IsValidHeadBuffer())
				return false;

			byte[] temp = new byte[ 2 ];
			System.Array.Copy(this.m_bHeadBuffer,14,temp,0,2);
			len = charArrayToInt( temp, 2 );
			return true;
		}
        /// <summary>
        /// ��Byteת��INT
        /// </summary>
        /// <param name="b">BYTE����</param>
        /// <param name="size">����</param>
        /// <returns></returns>
		public uint charArrayToInt( byte[] b , int size ) 
		{
			uint value = 0;
			for ( int i = 0;i < size;i++ ) 
			{
				value += (uint)(b[ i ] << ( i * 8 )) ;
			}
			return value;
		}
		
		
		public override string ToString() 
		{
			if (!this.IsValidHead)
				return "Invalid Packet Head\r\n";
			return "Sequece Id  :" + this.m_uiSeqID.ToString("X")
				+"\r\nMsg Category:" + this.m_mcCategory.ToString("X")
				+"\r\nService Key :" + this.m_skServiceKey.ToString("X")
				+"\r\nDateTime       :" + this.m_dtMsgDateTime.ToString("yyyy-MM-dd hh:mm:ss")
				+"\r\nBody Length :" + this.m_uiBodyLen.ToString("X")
				+"\r\n";
		}
		public byte[] ToByteArray()
		{
			if (this.IsValidHead)
				return this.m_bHeadBuffer;
			else
				return new byte[0];
		}

	}
}