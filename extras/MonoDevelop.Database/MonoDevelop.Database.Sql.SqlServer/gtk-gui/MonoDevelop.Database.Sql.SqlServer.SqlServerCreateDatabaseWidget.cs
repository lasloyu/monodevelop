
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Database.Sql.SqlServer
{
	public partial class SqlServerCreateDatabaseWidget
	{
		private global::Gtk.Table table;

		private global::Gtk.ComboBoxEntry comboCollations;

		private global::Gtk.Entry entryFilename;

		private global::Gtk.Entry entryName;

		private global::Gtk.HBox hbox1;

		private global::Gtk.SpinButton spinSize;

		private global::Gtk.ComboBox comboSize;

		private global::Gtk.HBox hbox2;

		private global::Gtk.SpinButton spinMaxSize;

		private global::Gtk.ComboBox comboMaxSize;

		private global::Gtk.HBox hbox3;

		private global::Gtk.SpinButton spinFilegrowth;

		private global::Gtk.ComboBox comboFilegrowth;

		private global::Gtk.Label label1;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Database.Sql.SqlServer.SqlServerCreateDatabaseWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Database.Sql.SqlServer.SqlServerCreateDatabaseWidget";
			// Container child MonoDevelop.Database.Sql.SqlServer.SqlServerCreateDatabaseWidget.Gtk.Container+ContainerChild
			this.table = new global::Gtk.Table (((uint)(6)), ((uint)(2)), false);
			this.table.Name = "table";
			this.table.RowSpacing = ((uint)(6));
			this.table.ColumnSpacing = ((uint)(6));
			this.table.BorderWidth = ((uint)(6));
			// Container child table.Gtk.Table+TableChild
			this.comboCollations = global::Gtk.ComboBoxEntry.NewText ();
			this.comboCollations.Name = "comboCollations";
			this.table.Add (this.comboCollations);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table[this.comboCollations]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.entryFilename = new global::Gtk.Entry ();
			this.entryFilename.CanFocus = true;
			this.entryFilename.Name = "entryFilename";
			this.entryFilename.IsEditable = true;
			this.entryFilename.InvisibleChar = '●';
			this.table.Add (this.entryFilename);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table[this.entryFilename]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.table.Add (this.entryName);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table[this.entryName]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.spinSize = new global::Gtk.SpinButton (0, 2147483647, 1);
			this.spinSize.CanFocus = true;
			this.spinSize.Name = "spinSize";
			this.spinSize.Adjustment.PageIncrement = 10;
			this.spinSize.ClimbRate = 1;
			this.spinSize.Numeric = true;
			this.hbox1.Add (this.spinSize);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.spinSize]));
			w4.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.comboSize = global::Gtk.ComboBox.NewText ();
			this.comboSize.AppendText (global::MonoDevelop.Database.AddinCatalog.GetString ("KB"));
			this.comboSize.AppendText (global::MonoDevelop.Database.AddinCatalog.GetString ("MB"));
			this.comboSize.AppendText (global::MonoDevelop.Database.AddinCatalog.GetString ("GB"));
			this.comboSize.AppendText (global::MonoDevelop.Database.AddinCatalog.GetString ("TB"));
			this.comboSize.Name = "comboSize";
			this.comboSize.Active = 1;
			this.hbox1.Add (this.comboSize);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.comboSize]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.table.Add (this.hbox1);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table[this.hbox1]));
			w6.TopAttach = ((uint)(3));
			w6.BottomAttach = ((uint)(4));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.spinMaxSize = new global::Gtk.SpinButton (0, 2147483647, 1);
			this.spinMaxSize.CanFocus = true;
			this.spinMaxSize.Name = "spinMaxSize";
			this.spinMaxSize.Adjustment.PageIncrement = 10;
			this.spinMaxSize.ClimbRate = 1;
			this.spinMaxSize.Numeric = true;
			this.hbox2.Add (this.spinMaxSize);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.spinMaxSize]));
			w7.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.comboMaxSize = global::Gtk.ComboBox.NewText ();
			this.comboMaxSize.AppendText (global::MonoDevelop.Database.AddinCatalog.GetString ("KB"));
			this.comboMaxSize.AppendText (global::MonoDevelop.Database.AddinCatalog.GetString ("MB"));
			this.comboMaxSize.AppendText (global::MonoDevelop.Database.AddinCatalog.GetString ("GB"));
			this.comboMaxSize.AppendText (global::MonoDevelop.Database.AddinCatalog.GetString ("TB"));
			this.comboMaxSize.AppendText (global::MonoDevelop.Database.AddinCatalog.GetString ("UNLIMITED"));
			this.comboMaxSize.Name = "comboMaxSize";
			this.comboMaxSize.Active = 1;
			this.hbox2.Add (this.comboMaxSize);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.comboMaxSize]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.table.Add (this.hbox2);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table[this.hbox2]));
			w9.TopAttach = ((uint)(4));
			w9.BottomAttach = ((uint)(5));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.spinFilegrowth = new global::Gtk.SpinButton (0, 2147483647, 1);
			this.spinFilegrowth.CanFocus = true;
			this.spinFilegrowth.Name = "spinFilegrowth";
			this.spinFilegrowth.Adjustment.PageIncrement = 10;
			this.spinFilegrowth.ClimbRate = 1;
			this.spinFilegrowth.Numeric = true;
			this.hbox3.Add (this.spinFilegrowth);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.spinFilegrowth]));
			w10.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.comboFilegrowth = global::Gtk.ComboBox.NewText ();
			this.comboFilegrowth.AppendText (global::MonoDevelop.Database.AddinCatalog.GetString ("KB"));
			this.comboFilegrowth.AppendText (global::MonoDevelop.Database.AddinCatalog.GetString ("MB"));
			this.comboFilegrowth.AppendText (global::MonoDevelop.Database.AddinCatalog.GetString ("GB"));
			this.comboFilegrowth.AppendText (global::MonoDevelop.Database.AddinCatalog.GetString ("TB"));
			this.comboFilegrowth.AppendText (global::MonoDevelop.Database.AddinCatalog.GetString ("%"));
			this.comboFilegrowth.Name = "comboFilegrowth";
			this.comboFilegrowth.Active = 1;
			this.hbox3.Add (this.comboFilegrowth);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.comboFilegrowth]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.table.Add (this.hbox3);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table[this.hbox3]));
			w12.TopAttach = ((uint)(5));
			w12.BottomAttach = ((uint)(6));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0f;
			this.label1.LabelProp = global::MonoDevelop.Database.AddinCatalog.GetString ("Name");
			this.table.Add (this.label1);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table[this.label1]));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0f;
			this.label3.LabelProp = global::MonoDevelop.Database.AddinCatalog.GetString ("Collation");
			this.table.Add (this.label3);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table[this.label3]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0f;
			this.label4.LabelProp = global::MonoDevelop.Database.AddinCatalog.GetString ("File Name");
			this.table.Add (this.label4);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table[this.label4]));
			w15.TopAttach = ((uint)(2));
			w15.BottomAttach = ((uint)(3));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0f;
			this.label5.LabelProp = global::MonoDevelop.Database.AddinCatalog.GetString ("Size");
			this.table.Add (this.label5);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table[this.label5]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0f;
			this.label6.LabelProp = global::MonoDevelop.Database.AddinCatalog.GetString ("Max Size");
			this.table.Add (this.label6);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table[this.label6]));
			w17.TopAttach = ((uint)(4));
			w17.BottomAttach = ((uint)(5));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0f;
			this.label7.LabelProp = global::MonoDevelop.Database.AddinCatalog.GetString ("File Growth");
			this.table.Add (this.label7);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table[this.label7]));
			w18.TopAttach = ((uint)(5));
			w18.BottomAttach = ((uint)(6));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.comboFilegrowth.Changed += new global::System.EventHandler (this.OnComboFilegrowthChanged);
			this.comboMaxSize.Changed += new global::System.EventHandler (this.OnComboMaxSizeChanged);
		}
	}
}