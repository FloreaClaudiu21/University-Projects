#pragma once
#include "general.h"
#include "button.h"
class project;

class menu_state {
public:
	bool C = false;
	button NEXT_ARROW;
	sf::Sprite BACKGROUND;
	sf::Texture BG_TEXTURE;
	int SELECTED_PROBLEM = 9;
	problems::main_problem PR;
	project *PROIECT = nullptr;
	std::vector<button> v_buttons;
	//////////////////////////////
	menu_state() {}
	menu_state(project* PR) {
		PROIECT = PR;
		init();
	}
	// INIT METHOD
	virtual void init();
	void next_page();
	// EXECUTE THE PROBLEM
	void execute_problem();
	// SELECT THE PROBLEM
	void select_problem(int ID);
	// CLICK
	void click(sf::Vector2i &M_POS);
	// UPDATE THE MENU STATE
	void update(sf::Vector2i &M_POS);
	// RENDER THE MENU STATE
	void render(sf::RenderTarget& WINDOW);
};

