#region License
// 
// Copyright (c) 2007-2009, Sean Chambers <schambers80@gmail.com>
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

namespace FluentMigrator.Example.Migrations
{
	[Migration(20090906205342)]
	public class AddGTDTables : Migration
	{
		public override void Up()
		{
			Create.Table("Contexts")
				.WithIdColumn()
				.WithColumn("Name").AsString().NotNullable();

			Create.Table("Projects")
				.WithIdColumn()
				.WithColumn("Name").AsString().NotNullable()
				.WithColumn("Position").AsInt32().NotNullable()
				.WithColumn("Done").AsBoolean().NotNullable();

			Create.Table("Users")
				.WithIdColumn()
				.WithColumn("Name").AsString().NotNullable()
				.WithColumn("Login").AsString().NotNullable()
				.WithColumn("Password").AsString().NotNullable()
				.WithColumn("PasswordSalt").AsString().NotNullable()
				.WithColumn("IsAdmin").AsBoolean().NotNullable();
		}

		public override void Down()
		{
			Delete.Table("Contexts");
			Delete.Table("Projects");
			Delete.Table("Users");
		}
	}
}