using System;
namespace User
{
	public class User_db_web
	{
		public string login { get; set; }
		public string password_hash { get; set; }

		void add_data(string login, string password_hash)
		{
			this.login = login;
			this.password_hash = password_hash;
		}
	}
	public class User_db_local
	{
		private Boolean is_anonymous;
		public User()
		{
			this.is_anonymous = true;
		}
	}
}


