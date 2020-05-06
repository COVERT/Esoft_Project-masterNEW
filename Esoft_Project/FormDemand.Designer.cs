﻿namespace Esoft_Project
{
    partial class FormDemand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxAgents = new System.Windows.Forms.ComboBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.textBoxMinArea = new System.Windows.Forms.TextBox();
            this.textBoxMinRooms = new System.Windows.Forms.TextBox();
            this.textBoxMinFloor = new System.Windows.Forms.TextBox();
            this.textBoxMinFloors = new System.Windows.Forms.TextBox();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaxArea = new System.Windows.Forms.TextBox();
            this.textBoxMaxRooms = new System.Windows.Forms.TextBox();
            this.textBoxMaxFloor = new System.Windows.Forms.TextBox();
            this.textBoxMaxFloors = new System.Windows.Forms.TextBox();
            this.labelAgent = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelRealEstate = new System.Windows.Forms.Label();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.labelMinArea = new System.Windows.Forms.Label();
            this.labelMaxArea = new System.Windows.Forms.Label();
            this.labelMinRooms = new System.Windows.Forms.Label();
            this.labelMaxRooms = new System.Windows.Forms.Label();
            this.labelMinFloor = new System.Windows.Forms.Label();
            this.labelMaxFloor = new System.Windows.Forms.Label();
            this.labelMinFloors = new System.Windows.Forms.Label();
            this.labelMamFloors = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewRealEstateSet_Land = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRealEstateSet_Apartment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewRealEstateSet_House = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // comboBoxAgents
            // 
            this.comboBoxAgents.FormattingEnabled = true;
            this.comboBoxAgents.Location = new System.Drawing.Point(3, 21);
            this.comboBoxAgents.Name = "comboBoxAgents";
            this.comboBoxAgents.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAgents.TabIndex = 0;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(3, 61);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClients.TabIndex = 1;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом ",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(3, 103);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 2;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(3, 143);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinPrice.TabIndex = 3;
            // 
            // textBoxMinArea
            // 
            this.textBoxMinArea.Location = new System.Drawing.Point(3, 181);
            this.textBoxMinArea.Name = "textBoxMinArea";
            this.textBoxMinArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinArea.TabIndex = 4;
            // 
            // textBoxMinRooms
            // 
            this.textBoxMinRooms.Location = new System.Drawing.Point(3, 218);
            this.textBoxMinRooms.Name = "textBoxMinRooms";
            this.textBoxMinRooms.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinRooms.TabIndex = 5;
            // 
            // textBoxMinFloor
            // 
            this.textBoxMinFloor.Location = new System.Drawing.Point(3, 255);
            this.textBoxMinFloor.Name = "textBoxMinFloor";
            this.textBoxMinFloor.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinFloor.TabIndex = 6;
            // 
            // textBoxMinFloors
            // 
            this.textBoxMinFloors.Location = new System.Drawing.Point(3, 294);
            this.textBoxMinFloors.Name = "textBoxMinFloors";
            this.textBoxMinFloors.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinFloors.TabIndex = 7;
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(119, 143);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxPrice.TabIndex = 8;
            // 
            // textBoxMaxArea
            // 
            this.textBoxMaxArea.Location = new System.Drawing.Point(119, 181);
            this.textBoxMaxArea.Name = "textBoxMaxArea";
            this.textBoxMaxArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxArea.TabIndex = 9;
            // 
            // textBoxMaxRooms
            // 
            this.textBoxMaxRooms.Location = new System.Drawing.Point(119, 218);
            this.textBoxMaxRooms.Name = "textBoxMaxRooms";
            this.textBoxMaxRooms.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxRooms.TabIndex = 10;
            // 
            // textBoxMaxFloor
            // 
            this.textBoxMaxFloor.Location = new System.Drawing.Point(119, 255);
            this.textBoxMaxFloor.Name = "textBoxMaxFloor";
            this.textBoxMaxFloor.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxFloor.TabIndex = 11;
            // 
            // textBoxMaxFloors
            // 
            this.textBoxMaxFloors.Location = new System.Drawing.Point(119, 294);
            this.textBoxMaxFloors.Name = "textBoxMaxFloors";
            this.textBoxMaxFloors.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxFloors.TabIndex = 12;
            // 
            // labelAgent
            // 
            this.labelAgent.AutoSize = true;
            this.labelAgent.Location = new System.Drawing.Point(12, 5);
            this.labelAgent.Name = "labelAgent";
            this.labelAgent.Size = new System.Drawing.Size(48, 13);
            this.labelAgent.TabIndex = 13;
            this.labelAgent.Text = "риелтор";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(12, 45);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(42, 13);
            this.labelClient.TabIndex = 14;
            this.labelClient.Text = "клиент";
            // 
            // labelRealEstate
            // 
            this.labelRealEstate.AutoSize = true;
            this.labelRealEstate.Location = new System.Drawing.Point(0, 85);
            this.labelRealEstate.Name = "labelRealEstate";
            this.labelRealEstate.Size = new System.Drawing.Size(129, 13);
            this.labelRealEstate.TabIndex = 15;
            this.labelRealEstate.Text = "объекты недвижимости";
            this.labelRealEstate.Click += new System.EventHandler(this.labelRealEstate_Click);
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Location = new System.Drawing.Point(12, 127);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(54, 13);
            this.labelMinPrice.TabIndex = 16;
            this.labelMinPrice.Text = "мин.цена";
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Location = new System.Drawing.Point(131, 127);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(61, 13);
            this.labelMaxPrice.TabIndex = 17;
            this.labelMaxPrice.Text = "Макс.цена";
            // 
            // labelMinArea
            // 
            this.labelMinArea.AutoSize = true;
            this.labelMinArea.Location = new System.Drawing.Point(12, 165);
            this.labelMinArea.Name = "labelMinArea";
            this.labelMinArea.Size = new System.Drawing.Size(41, 13);
            this.labelMinArea.TabIndex = 18;
            this.labelMinArea.Text = "Мин. S";
            // 
            // labelMaxArea
            // 
            this.labelMaxArea.AutoSize = true;
            this.labelMaxArea.Location = new System.Drawing.Point(131, 166);
            this.labelMaxArea.Name = "labelMaxArea";
            this.labelMaxArea.Size = new System.Drawing.Size(46, 13);
            this.labelMaxArea.TabIndex = 19;
            this.labelMaxArea.Text = "макс. S";
            // 
            // labelMinRooms
            // 
            this.labelMinRooms.AutoSize = true;
            this.labelMinRooms.Location = new System.Drawing.Point(12, 202);
            this.labelMinRooms.Name = "labelMinRooms";
            this.labelMinRooms.Size = new System.Drawing.Size(88, 13);
            this.labelMinRooms.TabIndex = 20;
            this.labelMinRooms.Text = "мин.кол.комнат";
            // 
            // labelMaxRooms
            // 
            this.labelMaxRooms.AutoSize = true;
            this.labelMaxRooms.Location = new System.Drawing.Point(116, 202);
            this.labelMaxRooms.Name = "labelMaxRooms";
            this.labelMaxRooms.Size = new System.Drawing.Size(94, 13);
            this.labelMaxRooms.TabIndex = 21;
            this.labelMaxRooms.Text = "макс.кол.комнат";
            // 
            // labelMinFloor
            // 
            this.labelMinFloor.AutoSize = true;
            this.labelMinFloor.Location = new System.Drawing.Point(12, 239);
            this.labelMinFloor.Name = "labelMinFloor";
            this.labelMinFloor.Size = new System.Drawing.Size(57, 13);
            this.labelMinFloor.TabIndex = 22;
            this.labelMinFloor.Text = "Мин.Этаж";
            // 
            // labelMaxFloor
            // 
            this.labelMaxFloor.AutoSize = true;
            this.labelMaxFloor.Location = new System.Drawing.Point(131, 241);
            this.labelMaxFloor.Name = "labelMaxFloor";
            this.labelMaxFloor.Size = new System.Drawing.Size(63, 13);
            this.labelMaxFloor.TabIndex = 23;
            this.labelMaxFloor.Text = "Маск.Этаж";
            // 
            // labelMinFloors
            // 
            this.labelMinFloors.AutoSize = true;
            this.labelMinFloors.Location = new System.Drawing.Point(12, 278);
            this.labelMinFloors.Name = "labelMinFloors";
            this.labelMinFloors.Size = new System.Drawing.Size(90, 13);
            this.labelMinFloors.TabIndex = 24;
            this.labelMinFloors.Text = "Мин.кол.Этажей";
            // 
            // labelMamFloors
            // 
            this.labelMamFloors.AutoSize = true;
            this.labelMamFloors.Location = new System.Drawing.Point(122, 278);
            this.labelMamFloors.Name = "labelMamFloors";
            this.labelMamFloors.Size = new System.Drawing.Size(97, 13);
            this.labelMamFloors.TabIndex = 25;
            this.labelMamFloors.Text = "Макс.Кол.Этажей";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(538, 282);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(619, 281);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 30;
            this.buttonEdit.Text = "изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(700, 282);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 31;
            this.buttonDel.Text = "удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewRealEstateSet_Land
            // 
            this.listViewRealEstateSet_Land.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23});
            this.listViewRealEstateSet_Land.FullRowSelect = true;
            this.listViewRealEstateSet_Land.GridLines = true;
            this.listViewRealEstateSet_Land.HideSelection = false;
            this.listViewRealEstateSet_Land.Location = new System.Drawing.Point(225, -2);
            this.listViewRealEstateSet_Land.MultiSelect = false;
            this.listViewRealEstateSet_Land.Name = "listViewRealEstateSet_Land";
            this.listViewRealEstateSet_Land.Size = new System.Drawing.Size(523, 126);
            this.listViewRealEstateSet_Land.TabIndex = 32;
            this.listViewRealEstateSet_Land.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Land.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_Land.Visible = false;
            this.listViewRealEstateSet_Land.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_Land_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "риелтор";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "клиент";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "объекты недвижимости";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "мин цена";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "макс цена";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "мин S";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "макс S";
            // 
            // listViewRealEstateSet_Apartment
            // 
            this.listViewRealEstateSet_Apartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader25,
            this.columnHeader26});
            this.listViewRealEstateSet_Apartment.FullRowSelect = true;
            this.listViewRealEstateSet_Apartment.GridLines = true;
            this.listViewRealEstateSet_Apartment.HideSelection = false;
            this.listViewRealEstateSet_Apartment.Location = new System.Drawing.Point(225, -2);
            this.listViewRealEstateSet_Apartment.MultiSelect = false;
            this.listViewRealEstateSet_Apartment.Name = "listViewRealEstateSet_Apartment";
            this.listViewRealEstateSet_Apartment.Size = new System.Drawing.Size(523, 126);
            this.listViewRealEstateSet_Apartment.TabIndex = 33;
            this.listViewRealEstateSet_Apartment.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Apartment.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "риелтор";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "клиент";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "объект";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "min Цена";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Max цена";
            // 
            // listViewRealEstateSet_House
            // 
            this.listViewRealEstateSet_House.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listViewRealEstateSet_House.FullRowSelect = true;
            this.listViewRealEstateSet_House.GridLines = true;
            this.listViewRealEstateSet_House.HideSelection = false;
            this.listViewRealEstateSet_House.Location = new System.Drawing.Point(225, -2);
            this.listViewRealEstateSet_House.MultiSelect = false;
            this.listViewRealEstateSet_House.Name = "listViewRealEstateSet_House";
            this.listViewRealEstateSet_House.Size = new System.Drawing.Size(523, 126);
            this.listViewRealEstateSet_House.TabIndex = 34;
            this.listViewRealEstateSet_House.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_House.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_House.Visible = false;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "риелтор";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "клиент";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "объект";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "мин цена";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Ширина";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "мин S";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "макс S";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "мин комнат";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "макс комнат";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "мин этажей";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "макс этажей";
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "мин кол этажей";
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "макс кол этажей";
            // 
            // FormDemand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewRealEstateSet_House);
            this.Controls.Add(this.listViewRealEstateSet_Apartment);
            this.Controls.Add(this.listViewRealEstateSet_Land);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelMamFloors);
            this.Controls.Add(this.labelMinFloors);
            this.Controls.Add(this.labelMaxFloor);
            this.Controls.Add(this.labelMinFloor);
            this.Controls.Add(this.labelMaxRooms);
            this.Controls.Add(this.labelMinRooms);
            this.Controls.Add(this.labelMaxArea);
            this.Controls.Add(this.labelMinArea);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.labelMinPrice);
            this.Controls.Add(this.labelRealEstate);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelAgent);
            this.Controls.Add(this.textBoxMaxFloors);
            this.Controls.Add(this.textBoxMaxFloor);
            this.Controls.Add(this.textBoxMaxRooms);
            this.Controls.Add(this.textBoxMaxArea);
            this.Controls.Add(this.textBoxMaxPrice);
            this.Controls.Add(this.textBoxMinFloors);
            this.Controls.Add(this.textBoxMinFloor);
            this.Controls.Add(this.textBoxMinRooms);
            this.Controls.Add(this.textBoxMinArea);
            this.Controls.Add(this.textBoxMinPrice);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.comboBoxAgents);
            this.Name = "FormDemand";
            this.Text = "FormDemand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAgents;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.TextBox textBoxMinArea;
        private System.Windows.Forms.TextBox textBoxMinRooms;
        private System.Windows.Forms.TextBox textBoxMinFloor;
        private System.Windows.Forms.TextBox textBoxMinFloors;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.TextBox textBoxMaxArea;
        private System.Windows.Forms.TextBox textBoxMaxRooms;
        private System.Windows.Forms.TextBox textBoxMaxFloor;
        private System.Windows.Forms.TextBox textBoxMaxFloors;
        private System.Windows.Forms.Label labelAgent;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelRealEstate;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.Label labelMinArea;
        private System.Windows.Forms.Label labelMaxArea;
        private System.Windows.Forms.Label labelMinRooms;
        private System.Windows.Forms.Label labelMaxRooms;
        private System.Windows.Forms.Label labelMinFloor;
        private System.Windows.Forms.Label labelMaxFloor;
        private System.Windows.Forms.Label labelMinFloors;
        private System.Windows.Forms.Label labelMamFloors;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewRealEstateSet_Land;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ListView listViewRealEstateSet_Apartment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listViewRealEstateSet_House;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
    }
}