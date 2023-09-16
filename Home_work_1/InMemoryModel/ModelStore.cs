using System;
using ModelElements;

namespace InMemoryModel
{
    public class ModelStore : IModelChanger
    {
        public PoligonalModel Models { get; set; }
        public Scene Scenes { get; set; }
        public Flash Flashes { get; set; }
        public Camera Cameras { get; set; }
        private IModelChangeObserver ChangeObserver { get; set; }

        public ModelStore(IModelChangeObserver changeObserver)
        {
            ChangeObserver = changeObserver;

            Models = new PoligonalModel(new Poligon(), new Texture());
            Flashes = new Flash(new Point3D(), new Angle3D(), new Color(), 0.0f);
            Cameras = new Camera();

            Scenes = new Scene(1, Models, Flashes);
        }

        public Scene GetScene(int n)
        {
            return Scenes;
        }

        public void NotifyChange(IModelChanger sender)
        {
            // Реализация метода NotifyChange
        }
    }
}