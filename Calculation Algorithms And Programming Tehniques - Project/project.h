#pragma once
#include "popup.h"
#include "problems.h"
#include "menu_state.h"
#include "resource.h"
#include "problem_state.h"

// STATES CLASS
enum class states {
	MAIN_MENU = 0, PROBLEM
};
class mainc;
// PROJECT CLASS
class project {
	public:
		popup POPUP;
		menu_state M;
		sf::Image ICON;
		sf::Image BG_IMG;
		problem_state P;
		problems PROBLEMS;
		mainc* MAIN = nullptr;
		sf::RenderWindow WINDOW;
        sf::Vector2i mousePosWindow;
		states STATE = states::MAIN_MENU;
		sf::Font ARIAL_FONT, TAHOMA_FONT;
		sf::Vector2u WSIZE;
		///////////////////
		// CONSTRUCTOR
		project() {
		}
		project(mainc* MA) {
			MAIN = MA;
		}
		
		// LOAD IMAGE FROM RESOURCE
		sf::Font LoadFontFromResource(const LPCWSTR NAME) {
			HRSRC rsrcData = FindResource(NULL, NAME, RT_RCDATA);
			if (!rsrcData)
				throw std::runtime_error("Failed to find resource.");
			DWORD rsrcDataSize = SizeofResource(NULL, rsrcData);
			if (rsrcDataSize <= 0)
				throw std::runtime_error("Failed to load resource.");
			HGLOBAL grsrcData = LoadResource(NULL, rsrcData);
			if (!grsrcData)
				throw std::runtime_error("Failed to load resource.");
			LPVOID firstByte = LockResource(grsrcData);
			if (!firstByte)
				throw std::runtime_error("Failed to lock resource.");
			sf::Font FONT;
			if (!FONT.loadFromMemory(firstByte, rsrcDataSize))
				throw std::runtime_error("Failed to load font from memory.");
			return FONT;
		}

		// LOAD IMAGE FROM RESOURCE
		sf::Image LoadImageFromResource(const LPCWSTR NAME) {
			HRSRC rsrcData = FindResource(NULL, NAME, RT_RCDATA);
			if (!rsrcData)
				throw std::runtime_error("Failed to find resource.");
			DWORD rsrcDataSize = SizeofResource(NULL, rsrcData);
			if (rsrcDataSize <= 0)
				throw std::runtime_error("Failed to load resource.");
			HGLOBAL grsrcData = LoadResource(NULL, rsrcData);
			if (!grsrcData)
				throw std::runtime_error("Failed to load resource.");
			LPVOID firstByte = LockResource(grsrcData);
			if (!firstByte)
				throw std::runtime_error("Failed to lock resource.");
			sf::Image image;
			if (!image.loadFromMemory(firstByte, rsrcDataSize))
				throw std::runtime_error("Failed to load image from memory.");
			return image;
		}

		// LOAD THE FONTS
		void load_fonts() {
			ARIAL_FONT = LoadFontFromResource(L"ARIALFONT");
			TAHOMA_FONT = LoadFontFromResource(L"TAHOMAFONT");
			return;
		}

		// LOAD THE IMAGES
		void load_images() {
			ICON = LoadImageFromResource(L"mainicon");
			BG_IMG = LoadImageFromResource(L"menubg");
			return;
		}

		// UPDATE THE STATES
		void update() {
			this->mousePosWindow = sf::Mouse::getPosition(WINDOW);
			switch (this->STATE) {
			case states::MAIN_MENU: {
				M.update(mousePosWindow);
				break;
			}
			case states::PROBLEM: {
				P.update(mousePosWindow);
				break;
			}
			}
		}
		// RENDER THE STATES
		void render(sf::RenderTarget &TARGET) {
			switch (this->STATE) {
				case states::MAIN_MENU: {
					M.render(TARGET);
					break;
				}
				case states::PROBLEM: {
					P.render(TARGET);
					break;
				}
			}
			return;
		}
		// CREATE THE WINDOW
		bool create_window() {
			this->WINDOW.create(sf::VideoMode(1024, 768), "Proiect ATP", sf::Style::Titlebar | sf::Style::Close);
			this->WINDOW.setKeyRepeatEnabled(true);
			this->WINDOW.setIcon(ICON.getSize().x, ICON.getSize().y, ICON.getPixelsPtr());
			this->WSIZE = sf::Vector2u(1024, 768);
			PROBLEMS = problems(this);
			M = menu_state(this);
			P = problem_state(this);
			POPUP = popup(this);
			// MAIN LOOP
			while (this->WINDOW.isOpen()) {
				sf::Event EV;
				while (this->WINDOW.pollEvent(EV)) {
					switch (EV.type) {
					case sf::Event::Closed: {
						this->WINDOW.close();
						exit(0);
						break;
					}
					case sf::Event::MouseButtonPressed: {
						switch (this->STATE) {
						case states::MAIN_MENU: {
							M.click(mousePosWindow);
							break;
						}
						case states::PROBLEM: {
							P.click(mousePosWindow);
							break;
						}
						}
					}
					}
				}
				// CLEAR THE SCREEN
				this->WINDOW.clear(sf::Color::Black);
				// UPDATE
				update();
				// DRAW THE FRAME
				render(this->WINDOW);
				// SHOW THE SCREEN
				this->WINDOW.display();
			}
			return true;
		}
};
