#pragma once
#include "general.h"
#include "problems.h"
enum class button_states { BTN_IDLE = 0, BTN_HOVER, BTN_ACTIVE };

class button {
private:
	sf::Text text;
	short unsigned id = 0;
	sf::RectangleShape shape;
	sf::Font *font = nullptr;
	sf::Color textIdleColor;
	sf::Color textHoverColor;
	sf::Color textActiveColor;
	sf::Color idleColor;
	sf::Color hoverColor;
	sf::Color activeColor;
	sf::Color outlineIdleColor;
	sf::Color outlineHoverColor;
	sf::Color outlineActiveColor;
	button_states buttonState = button_states::BTN_IDLE;
public:
	button() {}
	~button();
	button(int ID, float x, float y, float width, float height,
		sf::Font &font, std::string text, int character_size,
		sf::Color text_idle_color, sf::Color text_hover_color, sf::Color text_active_color,
		sf::Color idle_color, sf::Color hover_color, sf::Color active_color,
		sf::Color outline_idle_color = sf::Color::Transparent, sf::Color outline_hover_color = sf::Color::Transparent, sf::Color outline_active_color = sf::Color::Transparent);
	//Accessors
	const bool isPressed() const;
	const std::string getText() const;
	const short unsigned& getId() const;
	//Modifiers
	void setId(const short unsigned id);
	void setText(const std::string text);
	virtual bool can_execute(sf::Vector2i& mousePosWindow);
	//Functions
	void render(sf::RenderTarget& target);
	void update(sf::Vector2i &mousePosWindow);
};

