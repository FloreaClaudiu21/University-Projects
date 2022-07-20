#pragma once
#include "general.h"

class project;

class popup {
public:
	sf::Text INFO_TEXT;
	bool visible = true;
	project *PROJECT = nullptr;
	sf::RectangleShape BG_SHADE;
	//
	popup();
	popup(project* PR) {
		this->PROJECT = PR;
		init();
	};
	// SHOW THE POPUP WINDOW
	void show();
	// HIDE THE POPUP WINDOW
	void hide();
	// INIT METHOD
	virtual void init();
	// UPDATE THE INFO TEXT
	void update_info_text(std::string MSG);
	// UPDATE THE MENU STATE
	void update(sf::Vector2i& M_POS);
	// RENDER THE MENU STATE
	void render(sf::RenderTarget& WINDOW);
};

