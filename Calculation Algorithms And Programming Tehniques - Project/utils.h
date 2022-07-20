#pragma once
#include "general.h"
class mainc;
namespace UTIL {
	class utils {
	public:
		utils() {}
		mainc* MAIN = nullptr;
		utils(mainc *M) {
			MAIN = M;
		}
		void print_menu();
		// CREATE TEXT
		void text(sf::Text& TEXT, sf::Vector2f POSITION, sf::String T, sf::Color TEXT_COLOR);
		void text(sf::Text& TEXT, sf::Vector2f POSITION, sf::String T, sf::Color TEXT_COLOR, sf::Color OUT_COLOR);
		void text(sf::Text& TEXT, sf::Vector2f POSITION, sf::String T, sf::Color TEXT_COLOR, sf::Color OUT_COLOR, sf::Font F);
		void text(sf::Text& TEXT, sf::Vector2f POSITION, sf::String T, sf::Color TEXT_COLOR, sf::Color OUT_COLOR, sf::Font F, float THICKNESS);
	};
}

