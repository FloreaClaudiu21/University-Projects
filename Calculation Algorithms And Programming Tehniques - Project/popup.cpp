#include "popup.h"
#include "project.h"

popup::popup(){}

// SHOW THE POPUP
void popup::show() {
	this->visible = true;
	return;
}

// HIDE THE POPUP
void popup::hide() {
	this->visible = false;
	return;
}

// INITIALIZE THE POPUP WINDOW
void popup::init() {
	sf::Vector2u SIZE = this->PROJECT->WINDOW.getSize();
	sf::Vector2f V1(SIZE.x, SIZE.y);
	this->BG_SHADE.setSize(V1);
	this->BG_SHADE.setFillColor(sf::Color(0, 0, 0, 180));
	/////////////////////////////////////////////////////
	this->INFO_TEXT.setCharacterSize(21);
	this->INFO_TEXT.setOutlineThickness(1);
	this->INFO_TEXT.setLetterSpacing(3.0f);
	this->INFO_TEXT.setFont(this->PROJECT->TAHOMA_FONT);
	this->INFO_TEXT.setFillColor(sf::Color(240, 128, 128));
	this->INFO_TEXT.setOutlineColor(sf::Color(192,192,192, 120));
	return;
}

// UPDATE THE INFO TEXT
void popup::update_info_text(std::string MSG) {
	sf::Vector2f V;
	auto SIZE = this->PROJECT->WINDOW.getSize();
	V.y = 310;
	this->INFO_TEXT.setString(MSG);
	V.x = (SIZE.x / 2) - (INFO_TEXT.getLocalBounds().width / 2);
	this->INFO_TEXT.setPosition(V);
	return;
}

// UPDATE THE POPUP WINDOW
void popup::update(sf::Vector2i& M_POS) {}

// RENDER THE POPUP WINDOW
void popup::render(sf::RenderTarget& WINDOW) {
	WINDOW.draw(this->BG_SHADE);
	WINDOW.draw(this->INFO_TEXT);
	return;
}
