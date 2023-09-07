local UserInputService = game:GetService("UserInputService")

local function onInputBegan(input, _gameProcessed)
	if input.UserInputType == Enum.UserInputType.MouseButton1 then
		print("The left mouse button has been pressed!")
	end
end

UserInputService.InputBegan:Connect(onInputBegan)
