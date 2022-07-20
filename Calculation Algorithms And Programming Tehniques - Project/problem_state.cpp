#include "main.h"
#include "project.h"
#include "problem_state.h"

enum class BACK_ARROW_STATE {
	IDLE, HOVER, ACTIVE
};

sf::Text INFO_TEXT1;
BACK_ARROW_STATE STATE = BACK_ARROW_STATE::IDLE;
BACK_ARROW_STATE STATE1 = BACK_ARROW_STATE::IDLE;

// RENDER TITLE TO THE SCREEN
void info1(sf::RenderTarget& WINDOW, sf::Font& FONT, sf::Vector2u WSIZE) {
	sf::Vector2f V, V1;
	std::stringstream STREAM;
	/// /////////////////////
	STREAM << "    Apasati pe butonul 'BACK' pentru a va intoarce la meniul principal.\nSau puteti utiliza butonul 'RELOAD' ca sa reluati problema de la inceput.";
	INFO_TEXT1.setFont(FONT);
	INFO_TEXT1.setCharacterSize(18);
	INFO_TEXT1.setOutlineThickness(3);
	INFO_TEXT1.setLetterSpacing(2.f);
	INFO_TEXT1.setFillColor(sf::Color(255, 99, 99));
	INFO_TEXT1.setString(STREAM.str());
	INFO_TEXT1.setOutlineColor(sf::Color(0, 0, 0, 210));
	V.x = (WSIZE.x / 2) - (INFO_TEXT1.getLocalBounds().width / 2);
	V.y = (WSIZE.y / 2) - (INFO_TEXT1.getLocalBounds().height / 2 - 240);
	INFO_TEXT1.setPosition(V);
	return;
}

// RENDER TITLE TO THE SCREEN
void problem_state::result_init() {
	sf::Vector2f V;
	/// ///////////
	V.y = 300;
	this->RESULT_TEXT.setCharacterSize(20);
	this->RESULT_TEXT.setOutlineThickness(4);
	this->RESULT_TEXT.setLetterSpacing(3.0f);
	this->RESULT_TEXT.setFillColor(sf::Color::Magenta);
	this->RESULT_TEXT.setFont(this->PROIECT->ARIAL_FONT);
	this->RESULT_TEXT.setOutlineColor(sf::Color(0, 0, 0, 210));
	V.x = (this->PROIECT->WSIZE.x / 2) - (this->RESULT_TEXT.getLocalBounds().width / 2);
	this->RESULT_TEXT.setPosition(V);
	return;
}

// RENDER TITLE TO THE SCREEN
void problem_state::main_title_init() {
	sf::Vector2f V, V1;
	/// ///////////////
	std::ostringstream SS;
	SS << this->PR.DESC.c_str();
	this->MAIN_TITLE.setCharacterSize(27);
	this->MAIN_TITLE.setOutlineThickness(5);
	this->MAIN_TITLE.setLetterSpacing(2.5f);
	this->MAIN_TITLE.setString(this->PR.NUME);
	this->MAIN_TITLE.setFillColor(sf::Color::Cyan);
	this->MAIN_TITLE.setFont(this->PROIECT->ARIAL_FONT);
	this->MAIN_TITLE.setOutlineColor(sf::Color(0, 0, 0, 210));
	this->MAIN_TITLE.setStyle(sf::Uint32(sf::Text::Underlined));
	V1.x = (this->PROIECT->WSIZE.x / 2) - (this->MAIN_TITLE.getLocalBounds().width / 2);
	V1.y = (this->PROIECT->WSIZE.y / 2) - (this->MAIN_TITLE.getLocalBounds().height / 2 + 280);
	this->MAIN_TITLE.setPosition(V1);
	//
	this->TITLE_TEXT1.setString(SS.str());
	this->TITLE_TEXT1.setCharacterSize(20);
	this->TITLE_TEXT1.setOutlineThickness(4);
	this->TITLE_TEXT1.setLetterSpacing(2.6f);
	this->TITLE_TEXT1.setFont(this->PROIECT->ARIAL_FONT);
	this->TITLE_TEXT1.setOutlineColor(sf::Color(0, 0, 0, 210));
	V.x = (this->PROIECT->WSIZE.x / 2) - (this->TITLE_TEXT1.getLocalBounds().width / 2);
	V.y = (this->PROIECT->WSIZE.y / 2) - (this->TITLE_TEXT1.getLocalBounds().height / 2 + 210);
	this->TITLE_TEXT1.setPosition(V);
	return;
}

// INIT METHOD
void problem_state::init() {
	this->PR = this->PROIECT->PROBLEMS.P_9;
	// GENERATE INFO
	info1(this->PROIECT->WINDOW, this->PROIECT->ARIAL_FONT, this->PROIECT->WSIZE);
	// GENERATE MAIN TEXT
	main_title_init();
	// GENERATE RESULT TEXT
	result_init();
	// GENERATE BACK ARROW BUTTON
	BACK_ARROW = button(5, 40, 700, 120, 40, this->PROIECT->ARIAL_FONT, "« BACK", 16, sf::Color::White, sf::Color::White, sf::Color::White, sf::Color(77, 76, 125), sf::Color(130, 115, 151), sf::Color::Black, sf::Color(233, 213, 218), sf::Color(77, 76, 125), sf::Color(130, 115, 151));
	v_buttons.push_back(BACK_ARROW);
	// GENERATE RELOAD PROBLEM BUTTON
	RELOAD_BTN = button(6, 190, 700, 120, 40, this->PROIECT->ARIAL_FONT, "RELOAD", 16, sf::Color::White, sf::Color::White, sf::Color::White, sf::Color(77, 76, 125), sf::Color(130, 115, 151), sf::Color::Black, sf::Color(233, 213, 218), sf::Color(77, 76, 125), sf::Color(130, 115, 151));
	v_buttons.push_back(RELOAD_BTN);
	return;
}

// RELOAD THE PROBLEM
void problem_state::reload_page() {
	if (this->PROBLEM_RUNNING) {
		MessageBoxW(NULL, L"Asteptati ca problema sa termine de rulat inainte de a incepe de la capat!", L"Problema ruleaza..", MB_OKCANCEL | MB_ICONEXCLAMATION);
		return;
	}
	std::thread T;
	int result = MessageBoxW(NULL, L"Esti sigur ca doresti sa reincepi problema?", L"Reincepere problema curenta...", MB_YESNO | MB_ICONQUESTION);
	switch (result) {
	case IDYES:
		std::cout << std::endl;
		this->RESULT_TEXT.setString("");
		this->NEEDS_MATRIX_DRAW = false;
		std::cout << this->PR.NUME << " >> " << this->PR.DESC << std::endl;
		this->PROIECT->POPUP.update_info_text(this->PROIECT->P.PR.INSTRUCTION);
		T = std::thread(&menu_state::execute_problem, this->PROIECT->M);
		T.detach();
		break;
	default:
		break;
	}
	return;
}

// BACK PAGE EXECUTOR ON CLICK
void problem_state::back_page() {
	if (this->PROBLEM_RUNNING) {
		MessageBoxW(NULL, L"Asteptati ca problema sa termine de rulat inainte sa va intoarceti inapoi la meniul principal!", L"Problema ruleaza..", MB_OKCANCEL | MB_ICONEXCLAMATION);
		return;
	}
	int result = MessageBoxW(NULL, L"Esti sigur ca doresti sa te intorci la meniu principal?", L"Intoarcere la pagina principala...", MB_YESNO | MB_ICONQUESTION);
	switch (result) {
	case IDYES:
		this->PROBLEM_RUNNING = false;
		this->NEEDS_MATRIX_DRAW = false;
		this->RESULT_TEXT.setString("");
		this->PROIECT->P.SELECTED_PROBLEM = 0;
		this->PROIECT->MAIN->UTILS.print_menu();
		this->PROIECT->STATE = states::MAIN_MENU;
		break;
	default:
		break;
	}
	return;
}

// CLICK ON THE STATE
void problem_state::click(sf::Vector2i& M_POS) {
	if (this->PROIECT->POPUP.visible) {
		return;
	}
	for (button& B : v_buttons) {
		if (B.can_execute(M_POS)) {
			if (B.getId() == 5) {
				back_page();
				return;
			} else {
				reload_page();
				return;
			}
		}
	}
}

// SET AND SHOW THE RESULT TEXT
void set_result(const char* str, sf::Text& NT, project* PROIECT) {
	NT.setString(str);
	float x = (PROIECT->WSIZE.x / 2) - (NT.getLocalBounds().width / 2);
	NT.setPosition(sf::Vector2f(x, 300));
	PROIECT->P.NEEDS_RESULT_UPDATE = false;
	return;
}

// UPDATE METHOD
void problem_state::update(sf::Vector2i& M_POS) {
	// UPDATE THE MAIN TITLE
	main_title_init();
	// UPDATE THE RESULT TEXT
	if (this->NEEDS_RESULT_UPDATE) {
		set_result(this->RESULT_T_U.c_str(), this->RESULT_TEXT, this->PROIECT);
	}
	if (!this->PROIECT->POPUP.visible) {
		// UPDATE THE BUTTON STATE
		for (button& B : v_buttons) {
			B.update(M_POS);
		}
	}
	return;
}

// RENDER THE MATRIX FROM PROBLEM 37
void problem_state::render_matrix(sf::RenderTarget &WINDOW) {
	sf::Text T;
	std::stringstream SS;
	// //////////////////
	for (int R = 0; R < this->ROWNUMBER; R++) {
		SS << "L" << (R + 1) << ":\t";
        for (int C = 0; C < this->COLNUMBER; C++) {
			SS << MATRIX_37[R][C] << "\t";
		}
		SS << "\n";
	}
	T.setString(SS.str());
	T.setCharacterSize(22);
	T.setLineSpacing(1.3f);
	T.setOutlineThickness(4);
	T.setFillColor(sf::Color::White);
	T.setFont(this->PROIECT->ARIAL_FONT);
	T.setOutlineColor(sf::Color(0, 0, 0, 130));
	float x = (WINDOW.getSize().x / 2) - (T.getGlobalBounds().width / 2);
	T.setPosition(sf::Vector2f(x, 400));
	WINDOW.draw(T);
	return;
}

// RENDER METHOD
void problem_state::render(sf::RenderTarget& WINDOW) {
	this->PROIECT->M.BACKGROUND.setTexture(this->PROIECT->M.BG_TEXTURE);
	WINDOW.draw(this->PROIECT->M.BACKGROUND);
	WINDOW.draw(RESULT_TEXT);
	WINDOW.draw(MAIN_TITLE);
	WINDOW.draw(TITLE_TEXT1);
	WINDOW.draw(INFO_TEXT1);
	for (button& B : v_buttons) {
		B.render(WINDOW);
	}
	if (this->NEEDS_MATRIX_DRAW) {
		render_matrix(WINDOW);
	}
	if (this->PROIECT->POPUP.visible) {
		this->PROIECT->POPUP.render(WINDOW);
	}
	return;
}
