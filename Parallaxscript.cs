for (int i = 0; i < backgroundPrefabs.Count; i++)
{
    GameObject background = backgroundPrefabs[i];
    float scrollSpeed = scrollSpeeds[i];

    Vector3 newPosition = background.transform.position + (cameraPosition * scrollSpeed);

    // If the background has gone off the screen, move it to the opposite side
    if (newPosition.x < -screenSize.x / 2)
    {
        newPosition.x += screenSize.x;
    }
    else if (newPosition.x > screenSize.x / 2)
    {
        newPosition.x -= screenSize.x;
    }

    background.transform.position = newPosition;
    if (newPosition.x < -screenSize.x / 2)
    {
        newPosition.x += screenSize.x;
    }
    else if (newPosition.x > screenSize.x / 2)
    {
        newPosition.x -= screenSize.x;
    }

}