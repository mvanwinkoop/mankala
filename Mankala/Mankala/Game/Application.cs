using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;


//Application is the overseeing class that handles everything the game does, no matter what screen the user currently has open.
public class Application : Microsoft.Xna.Framework.Game
{
    GraphicsDeviceManager graphics;
    SpriteBatch spriteBatch;

    GameScreens gameState;

    enum GameScreens
    {
        StartScreen,
        GameScreen
    }

    Game game;
    StartScreen startScreen;

    public Application()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        gameState = GameScreens.StartScreen;
        startScreen = new StartScreen(this);

        this.IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);

        TextureHandler.content = Content;
        System.Diagnostics.Debug.Write(Content);

    }

    protected override void UnloadContent()
    {
        // TODO: Unload any non ContentManager content here
    }

    public void StartNewGame(GameFactory factory, GameRules rules)
    {
        gameState = GameScreens.GameScreen;
        System.Diagnostics.Debug.WriteLine("rules: " + rules);
        game = new Game(factory, rules);

    }

    protected override void Update(GameTime gameTime)
    {
        InputModule.Update();

        switch (gameState)
        {
            case GameScreens.StartScreen:
                startScreen.Update();
                break;
            case GameScreens.GameScreen:
                game.Update();
                break;
        }
        base.Update(gameTime);
    }


    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        spriteBatch.Begin();

        switch (gameState)
        {
            case GameScreens.StartScreen:
                startScreen.Draw(spriteBatch);
                break;
            case GameScreens.GameScreen:
                game.Draw(spriteBatch);
                break;
        }

        spriteBatch.End();

        base.Draw(gameTime);
    }

}

