#include "button.h"

button::button(int ID, float x, float y, float width, float height,
	sf::Font &font, std::string text, int character_size,
	sf::Color text_idle_color, sf::Color text_hover_color, sf::Color text_active_color,
	sf::Color idle_color, sf::Color hover_color, sf::Color active_color,
	sf::Color outline_idle_color, sf::Color outline_hover_color, sf::Color outline_active_color) {
	this->id = ID;
	this->buttonState = button_states::BTN_IDLE;
	this->shape.setPosition(sf::Vector2f(x, y));
	this->shape.setSize(sf::Vector2f(width, height));
	this->shape.setFillColor(idle_color);
	this->shape.setOutlineThickness(3.5f);
	this->shape.setOutlineColor(outline_idle_color);
	this->font = &font;
	this->text.setFont(font);
	this->text.setString(text);
	this->text.setFillColor(text_idle_color);
	this->text.setCharacterSize(character_size);
	this->text.setPosition(
		this->shape.getPosition().x + (this->shape.getGlobalBounds().width / 2.f - this->text.getGlobalBounds().width / 2.f),
		this->shape.getPosition().y + this->text.getGlobalBounds().height / 2
	);
	this->textIdleColor = text_idle_color;
	this->textHoverColor = text_hover_color;
	this->textActiveColor = text_active_color;
	this->idleColor = idle_color;
	this->hoverColor = hover_color;
	this->activeColor = active_color;
	this->outlineIdleColor = outline_idle_color;
	this->outlineHoverColor = outline_hover_color;
	this->outlineActiveColor = outline_active_color;
	return;
}

button::~button(){}
//Accessors
const bool button::isPressed() const {
	if (this->buttonState == button_states::BTN_ACTIVE)
		return true;
	return false;
}

const std::string button::getText() const {
	return this->text.getString();
}

const short unsigned &button::getId() const {
	return this->id;
}

// EXECUTE CODE
bool button::can_execute(sf::Vector2i& mousePosWindow) {
	if (this->shape.getGlobalBounds().contains(static_cast<sf::Vector2f>(mousePosWindow))) {
		if (sf::Mouse::isButtonPressed(sf::Mouse::Left)) {
			return true;
		}
	}
	return false;
}

//Modifiers
void button::setText(const std::string text) {
	this->text.setString(text);
}

void button::setId(const short unsigned id) {
	this->id = id;
}

//Functions
void button::update(sf::Vector2i &mousePosWindow) {
	// Idle
	this->buttonState = button_states::BTN_IDLE;
	// Hover
	if (this->shape.getGlobalBounds().contains(static_cast<sf::Vector2f>(mousePosWindow))) {
		this->buttonState = button_states::BTN_HOVER;
		if (sf::Mouse::isButtonPressed(sf::Mouse::Left)) {
			this->buttonState = button_states::BTN_ACTIVE;
		}
	}
	switch (this->buttonState) {
	case button_states::BTN_IDLE:
		this->shape.setFillColor(this->idleColor);
		this->text.setFillColor(this->textIdleColor);
		this->shape.setOutlineColor(this->outlineIdleColor);
		break;

	case button_states::BTN_HOVER:
		this->shape.setFillColor(this->hoverColor);
		this->text.setFillColor(this->textHoverColor);
		this->shape.setOutlineColor(this->outlineHoverColor);
		break;
	case button_states::BTN_ACTIVE:
		this->shape.setFillColor(this->activeColor);
		this->text.setFillColor(this->textActiveColor);
		this->shape.setOutlineColor(this->outlineActiveColor);
		break;
	default:
		this->shape.setFillColor(sf::Color::Red);
		this->text.setFillColor(sf::Color::Blue);
		this->shape.setOutlineColor(sf::Color::Green);
		break;
	}
}

// RENDER THE BUTTON
void button::render(sf::RenderTarget &target) {
	target.draw(this->shape);
	target.draw(this->text);
}
