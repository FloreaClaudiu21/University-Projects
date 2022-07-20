#pragma once
#include "general.h"
#include "button.h"
class project;

class problem_state {
public:
	bool C = false;
	button BACK_ARROW;
	button RELOAD_BTN;
	sf::Text MAIN_TITLE;
	sf::Text TITLE_TEXT1;
	sf::Text RESULT_TEXT;
	std::string RESULT_T_U;
	int SELECTED_PROBLEM = 9;
	problems::main_problem PR;
	int** MATRIX_37 = nullptr;
	project* PROIECT = nullptr;
	bool PROBLEM_RUNNING = false;
	std::vector<button> v_buttons;
	bool NEEDS_MATRIX_DRAW = false;
	int COLNUMBER = 0, ROWNUMBER = 0;
	bool NEEDS_RESULT_UPDATE = false;
	/////////////////////////////////
	problem_state() {}
	problem_state(project* PR) {
		PROIECT = PR;
		init();
	}
	// INIT METHOD
	virtual void init();
	// INIT MAIN TITLE
	void main_title_init();
	// RESULT TITLE
	void result_init();
	// BACK PAGE EXECUTOR ON CLICK
	void back_page();
	// RELOAD THE PROBLEM
	void reload_page();
	// CLICK
	void click(sf::Vector2i& M_POS);
	// UPDATE THE MENU STATE
	void update(sf::Vector2i& M_POS);
	// RENDER THE MENU STATE
	void render(sf::RenderTarget& WINDOW);
	// RENDER THE MATRIX FROM PROBLEM 37
	void render_matrix(sf::RenderTarget& WINDOW);
};

