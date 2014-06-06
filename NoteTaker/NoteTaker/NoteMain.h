#pragma once

#include "NoteMain.h"

namespace NoteTaker {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	[STAThread]
	void startApp(array<String^>^ arg) {
		Application::EnableVisualStyles();
		Application::SetCompatibleTextRenderingDefault(false);

		NoteTaker::NoteMain form;
		Application::Run(%form);
	}
	
	/// <summary>
	/// Summary for NoteMain
	/// </summary>
	public ref class NoteMain : public System::Windows::Forms::Form
	{
	public:
		NoteMain(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~NoteMain()
		{
			if (components)
			{
				delete components;
			}
		}

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->SuspendLayout();
			// 
			// NoteMain
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(284, 262);
			this->Name = L"NoteMain";
			this->Text = L"NoteMain";
			this->Load += gcnew System::EventHandler(this, &NoteMain::NoteMain_Load);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void NoteMain_Load(System::Object^  sender, System::EventArgs^  e) {
			 }
	};
}
