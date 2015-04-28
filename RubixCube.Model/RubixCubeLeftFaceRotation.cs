namespace RubixCube.Model
{
    internal class RubixCubeLeftFaceRotation
    {
        private readonly RubixCubeLeftFace newLeftFace;
        private readonly RubixCubeFrontFace oldFrontFace;
        private readonly RubixCubeFrontFace newFrontFace;
        private readonly RubixCubeTopFace oldTopFace;
        private readonly RubixCubeTopFace newTopFace;
        private readonly RubixCubeBottomFace oldBottomFace;
        private readonly RubixCubeBottomFace newBottomFace;
        private readonly RubixCubeBackFace oldBackFace;
        private readonly RubixCubeBackFace newBackFace;

        public RubixCubeLeftFaceRotation(RubixCube cube, RubixCubeLeftFace newLeftFace)
        {
            this.newLeftFace = newLeftFace;
            oldFrontFace = cube.FrontFace;
            newFrontFace = oldFrontFace.Clone();
            oldTopFace = cube.TopFace;
            newTopFace = oldTopFace.Clone();
            oldBottomFace = cube.BottomFace;
            newBottomFace = oldBottomFace.Clone();
            oldBackFace = cube.BackFace;
            newBackFace = oldBackFace.Clone();
            UpdateFaces();
            RemoveOldCubes();
            AddNewCubes();
        }

        public RubixCubeFrontFace NewFrontFace
        {
            get { return newFrontFace; }
        }

        public RubixCubeTopFace NewTopFace
        {
            get { return newTopFace; }
        }

        public RubixCubeBottomFace NewBottomFace
        {
            get { return newBottomFace; }
        }

        public RubixCubeBackFace NewBackFace
        {
            get { return newBackFace; }
        }

        private void UpdateFaces()
        {
            newFrontFace.TopLeftCube = newLeftFace.FrontTopCube;
            newFrontFace.LeftCube = newLeftFace.FrontCube;
            newFrontFace.BottomLeftCube = newLeftFace.FrontBottomCube;
            newTopFace.BackLeftCube = newLeftFace.BackTopCube;
            newTopFace.LeftCube = newLeftFace.TopCube;
            newTopFace.FrontLeftCube = newLeftFace.FrontTopCube;
            newBottomFace.BackLeftCube = newLeftFace.BackBottomCube;
            newBottomFace.LeftCube = newLeftFace.BottomCube;
            newBottomFace.FrontLeftCube = newLeftFace.FrontBottomCube;
            newBackFace.TopLeftCube = newLeftFace.BackTopCube;
            newBackFace.LeftCube = newLeftFace.BackCube;
            newBackFace.BottomLeftCube = newLeftFace.BackBottomCube;
        }

        private void RemoveOldCubes()
        {
            oldFrontFace.TopLeftCube.RemoveCubeWith2Faces(oldFrontFace.TopCube);
            oldFrontFace.CenterCube.RemoveCubeWith2Faces(oldFrontFace.LeftCube);
            oldFrontFace.BottomLeftCube.RemoveCubeWith2Faces(oldFrontFace.BottomCube);
            oldTopFace.CenterCube.RemoveCubeWith2Faces(oldTopFace.LeftCube);
            oldBottomFace.CenterCube.RemoveCubeWith2Faces(oldBottomFace.LeftCube);
            oldBackFace.TopLeftCube.RemoveCubeWith2Faces(oldBackFace.TopCube);
            oldBackFace.CenterCube.RemoveCubeWith2Faces(oldBackFace.LeftCube);
            oldBackFace.BottomLeftCube.RemoveCubeWith2Faces(oldBackFace.BottomCube);
        }

        private void AddNewCubes()
        {
            newFrontFace.TopLeftCube.AddCubeWith2Faces(newFrontFace.TopCube);
            newFrontFace.CenterCube.AddCubeWith2Faces(newFrontFace.LeftCube);
            newFrontFace.BottomLeftCube.AddCubeWith2Faces(newFrontFace.BottomCube);
            newTopFace.CenterCube.AddCubeWith2Faces(newTopFace.LeftCube);
            newBottomFace.CenterCube.AddCubeWith2Faces(newBottomFace.LeftCube);
            newBackFace.TopLeftCube.AddCubeWith2Faces(newBackFace.TopCube);
            newBackFace.CenterCube.AddCubeWith2Faces(newBackFace.LeftCube);
            newBackFace.BottomLeftCube.AddCubeWith2Faces(newBackFace.BottomCube);
        }
    }
}
