#include "main.h"
#include "project.h"
#include "menu_state.h"

enum class NEXT_ARROW_STATE {
	IDLE, HOVER, ACTIVE
};

sf::Text INFO_TEXT;
sf::Text TITLE_TEXT;
sf::CircleShape C_S_PROBLEM;
NEXT_ARROW_STATE STATE = NEXT_ARROW_STATE::IDLE;

// NEXT PAGE EXECUTOR ON CLICK
void menu_state::next_page() {
	std::cout << std::endl;
	this->PROIECT->P.PR = this->PR;
	this->PROIECT->STATE = states::PROBLEM;
	this->PROIECT->P.SELECTED_PROBLEM = this->SELECTED_PROBLEM;
	std::cout << this->PR.NUME << " >> " << this->PR.DESC << std::endl;
	this->PROIECT->POPUP.update_info_text(this->PROIECT->P.PR.INSTRUCTION);
	std::thread T(&menu_state::execute_problem, this);
	T.detach();
	return;
}

// EXECUTE THE PROBLEM
void menu_state::execute_problem() {
	this->PROIECT->PROBLEMS.execute_by_id(this->PR.ID);
	return;
}

// SELECT THE PROBLEM
void menu_state::select_problem(int ID) {
	this->SELECTED_PROBLEM = ID;
	this->PR = this->PROIECT->PROBLEMS.get_by_id(ID);
	return;
}

// RENDER INFO TO THE SCREEN
void info(sf::RenderTarget& WINDOW, sf::Font& FONT, sf::Vector2u WSIZE, int NR) {
	sf::Vector2f V, V1;
	std::stringstream STREAM;
	/// /////////////////////
	STREAM << "Apasati pe butonul 'NEXT' pentru a continua, problema selectata este cea cu numarul " << NR << ".\n";
	INFO_TEXT.setFont(FONT);
	INFO_TEXT.setCharacterSize(20);
	INFO_TEXT.setOutlineThickness(3);
	INFO_TEXT.setLetterSpacing(2.f);
	INFO_TEXT.setFillColor(sf::Color(255, 99, 99));
	INFO_TEXT.setString(STREAM.str());
	INFO_TEXT.setOutlineColor(sf::Color(0, 0, 0, 210));
	V.x = (WSIZE.x / 2) - (INFO_TEXT.getLocalBounds().width / 2);
	V.y = (WSIZE.y / 2) - (INFO_TEXT.getLocalBounds().height / 2 - 260);
	INFO_TEXT.setPosition(V);
	return;
}

// RENDER TITLE TO THE SCREEN
void title(sf::RenderTarget& WINDOW, sf::Font &FONT, sf::Vector2u WSIZE) {
	sf::Vector2f V, V1;
	std::stringstream STREAM;
	/// /////////////////////
	STREAM << "  Proiect Algoritmi si tehnici de programare." 
		<< "\n" << "Florea Claudiu Valentin | Grupa 604 | Anul I" << "\n";
	TITLE_TEXT.setFont(FONT);
	TITLE_TEXT.setCharacterSize(30);
	TITLE_TEXT.setOutlineThickness(5);
	TITLE_TEXT.setLetterSpacing(2.5f);
	TITLE_TEXT.setString(STREAM.str());
	TITLE_TEXT.setOutlineColor(sf::Color(0, 0, 0, 210));
	V.x = (WSIZE.x / 2) - (TITLE_TEXT.getLocalBounds().width / 2);
	V.y = (WSIZE.y / 2) - (TITLE_TEXT.getLocalBounds().height / 2 + 260);
	TITLE_TEXT.setPosition(V);
	return;
}

// INIT METHOD
void menu_state::init() {
	// COLORS
	this->PROIECT->MAIN->UTILS.print_menu();
	sf::Color HOVER_T = sf::Color::White;
	sf::Color IDLE_T = sf::Color(247, 226, 226);
	sf::Color ACTIVE_T = sf::Color(26, 19, 47);
	sf::Color IDLE_C = sf::Color(91, 125, 177);
	sf::Color HOVER_C = sf::Color(26, 19, 47);
	sf::Color ACTIVE_C = sf::Color(247, 226, 226);
	sf::Color IDLE_OUT = sf::Color(0, 0, 0, 200);
	sf::Color HOVER_OUT = sf::Color(91, 125, 177);
	sf::Color ACTIVE_OUT = sf::Color(0, 0, 0, 200);
	///////////////////////////////////////////////
	sf::Vector2f POS;
	float WIDTH = 180, HEIGHT = 60;
	this->PR = this->PROIECT->PROBLEMS.P_9;
	int PADDING_TOP = 30, PADDING_LEFT = 40;
	float WIDTH2 = this->PROIECT->WSIZE.x - WIDTH - (PADDING_LEFT * 2) - (WIDTH / 2);
	/////////////////////////////////////////////////////////////////////////////////
	POS.x = 0;
	POS.y = 180;
	// GENERATE CIRCLE
	C_S_PROBLEM.setRadius(8);
	C_S_PROBLEM.setOutlineThickness(5.0f);
	C_S_PROBLEM.setPosition(sf::Vector2f(10, 290));
	C_S_PROBLEM.setFillColor(sf::Color(255, 140, 50));
	C_S_PROBLEM.setOutlineColor(sf::Color(0, 0, 0, 30));
	// GENERATE BUTTONS AND DESC
	for (int I = 1; I <= 4; I++) {
		auto PROBLEM = this->PROIECT->PROBLEMS.get_by_number(I);
		button BUTTON = button(PROBLEM.ID, (POS.x + PADDING_LEFT), POS.y + (HEIGHT + PADDING_TOP) * I, WIDTH, HEIGHT, this->PROIECT->ARIAL_FONT, PROBLEM.NUME, 26, IDLE_T, HOVER_T, ACTIVE_T, IDLE_C, HOVER_C, ACTIVE_C, IDLE_C, HOVER_OUT, IDLE_OUT);
		button BUTTON_DESC = button(PROBLEM.ID, (POS.x + (PADDING_LEFT * 2) + WIDTH), POS.y + (HEIGHT + PADDING_TOP) * I, WIDTH2, HEIGHT, this->PROIECT->TAHOMA_FONT, PROBLEM.DESC, 14, ACTIVE_T, HOVER_T, HOVER_T, ACTIVE_C, HOVER_C, HOVER_C, ACTIVE_OUT, HOVER_OUT, HOVER_OUT);
		v_buttons.push_back(BUTTON);
		v_buttons.push_back(BUTTON_DESC);
	}
	// GENERATE NEXT ARROW BUTTON
	NEXT_ARROW = button(5, 850, 700, 120, 40, this->PROIECT->ARIAL_FONT, "NEXT »", 16, sf::Color::White, sf::Color::White, sf::Color::White, sf::Color(77, 76, 125), sf::Color(130, 115, 151), sf::Color::Black, sf::Color(233, 213, 218), sf::Color(77, 76, 125), sf::Color(130, 115, 151));
	v_buttons.push_back(NEXT_ARROW);
	// GENERATE INFO
	info(this->PROIECT->WINDOW, this->PROIECT->ARIAL_FONT, this->PROIECT->WSIZE, SELECTED_PROBLEM);
	// GENERATE TITLE
	title(this->PROIECT->WINDOW, this->PROIECT->ARIAL_FONT, this->PROIECT->WSIZE);
	// GENERATE BACKGROUND IMAGE
	this->BG_TEXTURE.loadFromImage(this->PROIECT->BG_IMG);
	this->BACKGROUND.setTexture(this->BG_TEXTURE);
    this->BACKGROUND.setScale(this->PROIECT->WSIZE.x / this->BACKGROUND.getLocalBounds().width, this->PROIECT->WSIZE.y / this->BACKGROUND.getLocalBounds().height);
	return;
}

// CLICK ON THE STATE
void menu_state::click(sf::Vector2i& M_POS) {
	for (button& B : v_buttons) {
		if (B.can_execute(M_POS)) {
			if (B.getId() == 5) {
				next_page();
				return;
		    }
			select_problem(B.getId());
			return;
		}
	}
}

// UPDATE METHOD
void menu_state::update(sf::Vector2i &M_POS) {
	// UPDATE THE BUTTON STATE
	for (button &B : v_buttons) {
		B.update(M_POS);
	}
	// UPDATE INFO TEXT
	std::stringstream STREAM;
	/// /////////////////////
	STREAM << "Apasati pe butonul 'NEXT' pentru a continua, problema selectata este cea cu numarul " << SELECTED_PROBLEM << ".\n";
	INFO_TEXT.setString(STREAM.str());
	return;
}

// RENDER METHOD
void menu_state::render(sf::RenderTarget &WINDOW) {
	switch (SELECTED_PROBLEM) {
	case 9:
		C_S_PROBLEM.setPosition(sf::Vector2f(10, 290));
		break;
	case 84:
		C_S_PROBLEM.setPosition(sf::Vector2f(10, 380));
		break;
	case 4:
		C_S_PROBLEM.setPosition(sf::Vector2f(10, 470));
		break;
	case 37:
		C_S_PROBLEM.setPosition(sf::Vector2f(10, 560));
		break;
	}
	this->BACKGROUND.setTexture(this->BG_TEXTURE);
	WINDOW.draw(this->BACKGROUND);
	WINDOW.draw(TITLE_TEXT);
	WINDOW.draw(INFO_TEXT);
	WINDOW.draw(C_S_PROBLEM);
	for (button &B : v_buttons) {
		B.render(WINDOW);
	}
	return;
}
